using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace tcirs_service.Models.Imp
{
    [Table("imp3220", Schema = "imp")]
    public class Imp3220
    {
        [Key, StringLength(4)] public string potldg { get; set; } = string.Empty;
        [StringLength(10)] public string impdclnum { get; set; } = string.Empty;
        public int dcllnenum { get; set; }
        public int seq { get; set; }
        [StringLength(35)] public string pmsnum { get; set; } = string.Empty;
        public int dteisu { get; set; }
        [StringLength(17)] public string pmsisuath { get; set; } = string.Empty;
        [StringLength(1)] public string mnt { get; set; } = string.Empty;
        [StringLength(6)] public string uidamn { get; set; } = string.Empty;
        public DateTime dtetmeamn { get; set; }
        public DateTime ingdte { get; set; }
        public int ingyer { get; set; }
        public int ingmth { get; set; }
        public int ingday { get; set; }
        [StringLength(2)] public string dclyer { get; set; } = string.Empty;
        [StringLength(2)] public string dclmth { get; set; } = string.Empty;
    }
}
