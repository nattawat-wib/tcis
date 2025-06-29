using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace tcirs_service.Models.Umgs
{
    [Table("import_list_f", Schema = "ugms")]
    public class ImportListF
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("importrefno")]
        [Required]
        [StringLength(32)]
        public string ImportRefNo { get; set; } = string.Empty;

        [Column("documentno")]
        [StringLength(100)]
        public string? DocumentNo { get; set; }

        [Column("listf_date")]
        public DateTime? ListFDate { get; set; }

        [Column("liftf_day")]
        public int LiftFDay { get; set; }

        [Column("status")]
        [StringLength(32)]
        public string Status { get; set; } = string.Empty;

        [Column("created_by")]
        [StringLength(100)]
        public string CreatedBy { get; set; } = string.Empty;

        [Column("created_date")]
        public DateTime? CreatedDate { get; set; }

        [Column("updated_by")]
        [StringLength(100)]
        public string? UpdatedBy { get; set; }

        [Column("updated_date")]
        public DateTime? UpdatedDate { get; set; }
    }
}
