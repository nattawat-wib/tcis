using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace tcirs_service.Models.Umgs
{
    [Table("send_doc_attachments", Schema = "ugms")]
    public class SendDocAttachment
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("send_doc_id")]
        public int SendDocId { get; set; }

        [Column("file_name")]
        public string? FileName { get; set; }

        [Column("file_type")]
        public string FileType { get; set; } = null!;

        [Column("file_size")]
        public int FileSize { get; set; }

        [Column("file_data")]
        public byte[] FileData { get; set; } = null!;

        [Column("uploaded_by")]
        public string UploadedBy { get; set; } = null!;

        [Column("uploaded_at")]
        public DateTime UploadedAt { get; set; }
    }
}
