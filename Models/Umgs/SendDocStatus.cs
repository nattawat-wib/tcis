using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace tcirs_service.Models.Umgs
{
    [Table("send_doc_status", Schema = "ugms")]
    public class SendDocStatus
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("status_name_th")]
        [MaxLength(100)]
        public string StatusNameTh { get; set; } = null!;

        [Column("status_name_en")]
        [MaxLength(100)]
        public string? StatusNameEn { get; set; }

        [Column("is_active")]
        public bool IsActive { get; set; }

        [Column("create_date")]
        public DateTime? CreateDate { get; set; }
    }
}
