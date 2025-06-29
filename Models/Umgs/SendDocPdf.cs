using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace tcirs_service.Models.Umgs
{
    [Table("send_doc_pdf", Schema = "ugms")]
    public class SendDocPdf
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("send_doc_id")]
        public int SendDocId { get; set; }

        [Column("importrefno")]
        [MaxLength(255)]
        public string ImportRefNo { get; set; } = null!;

        [Column("pdf_file_name")]
        [MaxLength(255)]
        public string PdfFileName { get; set; } = null!;

        [Column("pdf_file_size")]
        public int PdfFileSize { get; set; }

        [Column("pdf_file_data")]
        public byte[] PdfFileData { get; set; } = null!;

        [Column("exported_by")]
        [MaxLength(100)]
        public string ExportedBy { get; set; } = null!;

        [Column("exported_at")]
        public DateTime ExportedAt { get; set; }

        [Column("pdf_file_path")]
        [MaxLength(500)]
        public string PdfFilePath { get; set; } = null!;
    }
}
