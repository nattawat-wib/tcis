using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace tcirs_service.Models.Umgs
{
    [Table("mscity", Schema = "ugms")]
    public class MsCity
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }

        [Column("CityCode")]
        [StringLength(3)]
        public string CityCode { get; set; } = string.Empty;

        [Column("CityName")]
        [StringLength(50)]
        public string CityName { get; set; } = string.Empty;

        [Column("Status")]
        [StringLength(1)]
        public string Status { get; set; } = string.Empty;

        [Column("IsDelete")]
        public int IsDelete { get; set; }
    }
}
