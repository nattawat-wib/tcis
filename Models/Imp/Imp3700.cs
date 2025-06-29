using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace tcirs_service.Models.Imp
{
    [Table("imp3700", Schema = "imp")]
    public class Imp3700
    {
        [Key, StringLength(4)] public string potldg { get; set; } = string.Empty;
        [StringLength(10)] public string ttndclnum { get; set; } = string.Empty;
        [StringLength(17)] public string cmptaxnum { get; set; } = string.Empty;
        public int cmpbrn { get; set; }
        [StringLength(120)] public string cmpnme { get; set; } = string.Empty;
        [StringLength(70)] public string cmpnmeeng { get; set; } = string.Empty;
        [StringLength(70)] public string adr { get; set; } = string.Empty;
        [StringLength(35)] public string tmbnme { get; set; } = string.Empty;
        [StringLength(35)] public string ampnme { get; set; } = string.Empty;
        [StringLength(35)] public string prvnme { get; set; } = string.Empty;
        [StringLength(9)] public string poscde { get; set; } = string.Empty;
        [StringLength(17)] public string brktaxno { get; set; } = string.Empty;
        public int brkbrn { get; set; }
        public int dtearv { get; set; }
        [StringLength(35)] public string vslnme { get; set; } = string.Empty;
        [StringLength(1)] public string tspmde { get; set; } = string.Empty;
        [StringLength(35)] public string masbil { get; set; } = string.Empty;
        [StringLength(35)] public string houbil { get; set; } = string.Empty;
        [StringLength(512)] public string shpmrk { get; set; } = string.Empty;
        [StringLength(2)] public string ctyogn { get; set; } = string.Empty;
        [StringLength(2)] public string ctycns { get; set; } = string.Empty;
        [StringLength(2)] public string ctypch { get; set; } = string.Empty;
        [StringLength(2)] public string ctydes { get; set; } = string.Empty;
        public int totpkgamt { get; set; }
        [StringLength(3)] public string pkgunt { get; set; } = string.Empty;
        public decimal wgtgos { get; set; }
        [StringLength(3)] public string wgtgosunt { get; set; } = string.Empty;
        public int potdis { get; set; }
        public int potrea { get; set; }
        public int potreaexp { get; set; }
        public int potlodexp { get; set; }
        public int dteaud { get; set; }
        public int dterea { get; set; }
        public int dtedlv { get; set; }
        public int dtereaexp { get; set; }
        public int dtelodexp { get; set; }
        public int tmeaud { get; set; }
        public int tmerea { get; set; }
        public int tmedlv { get; set; }
        public int tmereaexp { get; set; }
        public int tmelodexp { get; set; }
        [StringLength(6)] public string uidaud { get; set; } = string.Empty;
        [StringLength(6)] public string uidrea { get; set; } = string.Empty;
        [StringLength(6)] public string uiddlv { get; set; } = string.Empty;
        [StringLength(6)] public string uidreaexp { get; set; } = string.Empty;
        [StringLength(6)] public string uidlodexp { get; set; } = string.Empty;
        public int dtedpt { get; set; }
        [StringLength(35)] public string vslnmeexp { get; set; } = string.Empty;
        [StringLength(12)] public string voynum { get; set; } = string.Empty;
        [StringLength(1)] public string tspmdeexp { get; set; } = string.Empty;
        [StringLength(6)] public string uidamn { get; set; } = string.Empty;
        public DateTime dtetmeamn { get; set; }
        [StringLength(1)] public string mnt { get; set; } = string.Empty;
        [StringLength(35)] public string masbilexp { get; set; } = string.Empty;
        [StringLength(35)] public string houbilexp { get; set; } = string.Empty;
        [StringLength(256)] public string rmk { get; set; } = string.Empty;
        [StringLength(512)] public string rearmk { get; set; } = string.Empty;
        [StringLength(4)] public string dclsts { get; set; } = string.Empty;
        public int dtertn { get; set; }
        public int tmertn { get; set; }
        [StringLength(6)] public string uidrtn { get; set; } = string.Empty;
        [StringLength(512)] public string rtnrmk { get; set; } = string.Empty;
        public DateTime ingdte { get; set; }
        public int ingyer { get; set; }
        public int ingmth { get; set; }
        public int ingday { get; set; }
        [StringLength(2)] public string dclyer { get; set; } = string.Empty;
    }
}
