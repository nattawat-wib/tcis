using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace tcirs_service.Models.Umgs
{
    [Table("msdocument", Schema = "ugms")]
    public class MsDocument
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }

        [Column("DocType")]
        [StringLength(6)]
        public string DocType { get; set; } = string.Empty;

        [Column("DocName")]
        [StringLength(25)]
        public string DocName { get; set; } = string.Empty;

        [Column("Status")]
        public int Status { get; set; }

        [Column("IsDelete")]
        public int IsDelete { get; set; }

        [Column("CreatedBy")]
        [StringLength(100)]
        public string CreatedBy { get; set; } = string.Empty;

        [Column("CreatedDate", TypeName = "timestamptz")]
        public DateTime CreatedDate { get; set; }

        [Column("UpdatedBy")]
        [StringLength(100)]
        public string? UpdatedBy { get; set; }

        [Column("UpdatedDate", TypeName = "timestamptz")]
        public DateTime? UpdatedDate { get; set; }
    }
}
