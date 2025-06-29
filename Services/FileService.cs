using Renci.SshNet;
using tcirs_service.DTOs;
using tcirs_service.Repositories;

namespace tcirs_service.Services
{
    public class FileService : IFileService
    {
        private readonly string _basePath = Path.Combine(Directory.GetCurrentDirectory(), "Uploads");
        string host = "172.19.10.49";
        string username = "tcirs";
        string password = "tcirsFile";
        string remoteDirectory = "/habor/upload";

        private IFileRepositories _fileRepositories;
        public FileService(IFileRepositories fileRepositories)
        {
            if (!Directory.Exists(_basePath))
                Directory.CreateDirectory(_basePath);
            _fileRepositories = fileRepositories;
        }

        public string UploadFileWithSftp(string localFilePath, string remoteFileName)
        {

            using var sftp = new SftpClient(host, username, password);
            sftp.Connect();

            if (!sftp.Exists(remoteDirectory))
            {
                sftp.CreateDirectory(remoteDirectory);
            }
            using var fileStream = File.OpenRead(localFilePath);
            var remoteFilePath = $"{remoteDirectory}/{remoteFileName}";
            sftp.UploadFile(fileStream, remoteFilePath);
            sftp.Disconnect();
            return remoteFilePath;
        }

        public byte[] DownloadFileWithSftp(string remoteFilePath)
        {
            using var sftp = new SftpClient(host, username, password);
            sftp.Connect();

            if (!sftp.Exists(remoteFilePath))
            {
                throw new Exception($"File {remoteFilePath} does not exist on the server.");
            }
            using var ms = new MemoryStream();
            sftp.DownloadFile(remoteFilePath, ms);
            sftp.Disconnect();

            ms.Position = 0;
            return ms.ToArray();
        }

        public async Task SaveFileUploadToTable(List<FileUploadToTable> request)
        {
            await Task.WhenAll(request.Where(x => x.TypeUpload == TypeUpload.SDPDF).Select(item => _fileRepositories.InsertSendDocPDF(item)));
        }
    }
}
