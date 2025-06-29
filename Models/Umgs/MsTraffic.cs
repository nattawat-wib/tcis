using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace tcirs_service.Models.Umgs
{
    [Table("mstraffic", Schema = "ugms")]
    public class MsTraffic
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }

        [Column("TraficCode")]
        public int TraficCode { get; set; }

        [Column("TrafficDese")]
        [StringLength(50)]
        public string TrafficDese { get; set; } = string.Empty;

        [Column("TrafficDeseEn")]
        [StringLength(50)]
        public string TrafficDeseEn { get; set; } = string.Empty;

        [Column("Status")]
        public char Status { get; set; }

        [Column("IsDelete")]
        public int IsDelete { get; set; }
    }
}
