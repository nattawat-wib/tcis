using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace tcirs_service.Models.Imp
{
    [Table("imp3210", Schema = "imp")]
    public class Imp3210
    {
        [Key, StringLength(4)] public string potldg { get; set; } = string.Empty;
        [StringLength(10)] public string impdclnum { get; set; } = string.Empty;
        public int dcllnenum { get; set; }
        public int seq { get; set; }
        [StringLength(4)] public string dtytyp { get; set; } = string.Empty;
        public decimal dtyrte { get; set; }
        public decimal dtyspe { get; set; }
        [StringLength(1)] public string specal { get; set; } = string.Empty;
        public decimal dtyamt { get; set; }
        public decimal dtyamtp { get; set; }
        public decimal emtdty { get; set; }
        public int mthdty { get; set; }
        public decimal adddtyrte { get; set; }
        public decimal adddty { get; set; }
        public decimal dpsamt { get; set; }
        [StringLength(1)] public string mnt { get; set; } = string.Empty;
        [StringLength(6)] public string uidamn { get; set; } = string.Empty;
        public DateTime dtetmeamn { get; set; }
        public decimal crgamt { get; set; }
        public decimal addamt { get; set; }
        public int addnum { get; set; }
        public decimal argdtyrte { get; set; }
        public decimal argdtyspe { get; set; }
        [StringLength(1)] public string argspecal { get; set; } = string.Empty;
        public DateTime ingdte { get; set; }
        public int ingyer { get; set; }
        public int ingmth { get; set; }
        public int ingday { get; set; }
        [StringLength(2)] public string dclyer { get; set; } = string.Empty;
        [StringLength(2)] public string dclmth { get; set; } = string.Empty;
    }
}
