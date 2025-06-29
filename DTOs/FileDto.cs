namespace tcirs_service.DTOs
{
    public enum TypeUpload
    {
        //None Input
        None = 0,
        //Table Send Document PDF
        SDPDF = 1,
        //Table Send Document Attachment
        SDA = 2,
    }
    public class FileUploadRequest
    {
        public string? ImportRefNo { get; set; } = string.Empty;
        public string? DocumentNo { get; set; } = string.Empty;
        public TypeUpload typeUpload { get; set; } = TypeUpload.SDPDF;
        public List<IFormFile> Files { get; set; } = new List<IFormFile>();
    }

    public class FileUploadResponse
    {
        public string OriginalFileName { get; set; } = string.Empty;
        public string UniqueFileName { get; set; } = string.Empty;
        public string RemoteFilePath { get; set; } = string.Empty;
        public double SizeInKb { get; set; }
    }

    public class FileUploadToTable
    {
        public string? ImportRefNo { get; set; } = string.Empty;
        public string? DocumentNo { get; set; } = string.Empty;
        public TypeUpload TypeUpload { get; set; } = TypeUpload.None;
        public string? PdfFileName { get; set; } = string.Empty;
        public double PdfFileSize { get; set; } = 0.0;
        public byte[] PdfFileData { get; set; }
        public string? UniqueFileName { get; set; } = string.Empty;
        public string? PdfFilePath { get; set; } = string.Empty;
        public string? CreatedBy { get; set; } = "admin";
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;

    }
}
