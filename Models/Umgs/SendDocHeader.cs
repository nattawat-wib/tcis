using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace tcirs_service.Models.Umgs
{
    [Table("send_doc_header", Schema = "ugms")]
    public class SendDocHeader
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("importrefno")]
        [MaxLength(32)]
        public string ImportRefNo { get; set; } = null!;

        [Column("documentno")]
        [MaxLength(100)]
        public string DocumentNo { get; set; } = null!;

        [Column("documen_type")]
        [MaxLength(10)]
        public string DocumenType { get; set; } = null!;

        [Column("release_department")]
        public int ReleaseDepartment { get; set; }

        [Column("release_date")]
        public DateTime ReleaseDate { get; set; }

        [Column("release_by")]
        public int ReleaseBy { get; set; }

        [Column("status")]
        public int Status { get; set; }

        [Column("created_by")]
        [MaxLength(100)]
        public string CreatedBy { get; set; } = null!;

        [Column("created_date")]
        public DateTime CreatedDate { get; set; }

        [Column("updated_by")]
        [MaxLength(100)]
        public string UpdatedBy { get; set; } = null!;

        [Column("updated_date")]
        public DateTime UpdatedDate { get; set; }

        [Column("recive_date")]
        public DateTime ReciveDate { get; set; }

        [Column("recive_by")]
        [MaxLength(255)]
        public string ReciveBy { get; set; } = null!;

        [Column("release_day")]
        public short ReleaseDay { get; set; }

        [Column("recipient_type")]
        [MaxLength(255)]
        public string RecipientType { get; set; } = null!;

        [Column("recipient_name")]
        [MaxLength(255)]
        public string RecipientName { get; set; } = null!;

        [Column("recipient_address")]
        [MaxLength(255)]
        public string RecipientAddress { get; set; } = null!;

        [Column("tracking_number")]
        [MaxLength(255)]
        public string TrackingNumber { get; set; } = null!;
    }
}
