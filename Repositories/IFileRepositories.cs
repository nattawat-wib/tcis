using tcirs_service.DTOs;

namespace tcirs_service.Repositories
{
    public interface IFileRepositories
    {
        Task InsertSendDocPDF(FileUploadToTable request);
    }
}
