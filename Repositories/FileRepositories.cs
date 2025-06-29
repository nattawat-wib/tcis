using Dapper;
using tcirs_service.DTOs;
using tcirs_service.Extension;

namespace tcirs_service.Repositories
{
    public class FileRepositories : BaseRepository, IFileRepositories
    {
        public FileRepositories(IConfiguration configuration) : base(configuration) { }
        public async Task InsertSendDocPDF(FileUploadToTable request)
        {
            const string sql = @"
                INSERT INTO ugms.send_doc_pdf (
                    importrefno,
                    pdf_file_name,
                    pdf_file_size,
                    pdf_file_data,
                    created_by,
                    created_date,
                    pdf_file_path,
                    documentno
                )
                VALUES (
                    @ImportRefNo,
                    @PdfFileName,
                    @PdfFileSize,
                    @PdfFileData,
                    @CreatedBy,
                    @CreatedDate,
                    @PdfFilePath,
                    @DocumentNo
                );";

            try
            {
                using var connection = CreateConnection();
                await connection.OpenAsync();
                using var transaction = await connection.BeginTransactionAsync();

                await connection.ExecuteAsync(sql, request, transaction);

                await transaction.CommitAsync();
            }
            catch (Exception ex)
            {
                const string errorMessage = "An error occurred while inserting SendDocPDF data.";
                throw new Exception(errorMessage, ex);
            }
        }
    }
}
