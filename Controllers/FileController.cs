using Microsoft.AspNetCore.Mvc;
using tcirs_service.DTOs;
using tcirs_service.Services;

namespace tcirs_service.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FileController : ControllerBase
    {
        private readonly IFileService _fileService;

        public FileController(IFileService fileService)
        {
            _fileService = fileService;
        }

        [HttpPost("upload")]
        public async Task<IActionResult> Upload([FromForm] FileUploadRequest request)
        {
            if (request.Files == null || request.Files.Count == 0)
            {
                return BadRequest("No file received.");
            }
            List<FileUploadResponse> resultList = new List<FileUploadResponse>();
            List<FileUploadToTable> dataInsert = new List<FileUploadToTable>();
            foreach (var file in request.Files)
            {
                double sizeInKB = file.Length / 1024.0;
                var tempPath = Path.Combine(Path.GetTempPath(), file.FileName);
                var extension = Path.GetExtension(file.FileName);
                var uniqueFileName = $"{Guid.NewGuid()}{extension}";
                using (var stream = new FileStream(tempPath, FileMode.Create))
                {
                    await file.CopyToAsync(stream);
                }
                string remoteFilePath = _fileService.UploadFileWithSftp(tempPath, uniqueFileName);
                var fileBytes = await System.IO.File.ReadAllBytesAsync(tempPath);
                dataInsert.Add(new FileUploadToTable
                {
                    ImportRefNo = request.ImportRefNo,
                    DocumentNo = request.DocumentNo,
                    TypeUpload = request.typeUpload,
                    PdfFileName = file.FileName,
                    PdfFileData = fileBytes,
                    UniqueFileName = uniqueFileName,
                    PdfFilePath = remoteFilePath,
                    PdfFileSize = sizeInKB,
                    CreatedBy = User.Identity?.Name ?? "UnknownUser"
                });
                resultList.Add(new FileUploadResponse
                {
                    OriginalFileName = file.FileName,
                    UniqueFileName = uniqueFileName,
                    RemoteFilePath = remoteFilePath,
                    SizeInKb = sizeInKB
                });
                System.IO.File.Delete(tempPath);
            }

            await _fileService.SaveFileUploadToTable(dataInsert);
            return Ok(resultList);
        }

        [HttpGet("download/{remoteFilePath}")]
        public async Task<IActionResult> DownloadFile(string remoteFilePath)
        {
            var fileStream = _fileService.DownloadFileWithSftp(Uri.UnescapeDataString(remoteFilePath));
            if (fileStream == null) return NotFound();

            return File(fileStream, "application/octet-stream", remoteFilePath);
        }
    }
}
