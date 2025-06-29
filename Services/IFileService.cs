using tcirs_service.DTOs;

namespace tcirs_service.Services
{
    public interface IFileService
    {
        string UploadFileWithSftp(string localFilePath, string remoteFileName);
        byte[] DownloadFileWithSftp(string remoteFilePath);
        Task SaveFileUploadToTable(List<FileUploadToTable> request);
    }
}
