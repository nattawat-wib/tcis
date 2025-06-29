using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace tcirs_service.Models.Imp
{
    [Table("imp3000", Schema = "imp")]
    public class Imp3000
    {
        [Key]
        [StringLength(4)]
        public string potldg { get; set; } = string.Empty;

        [StringLength(10)] public string impdclnum { get; set; } = string.Empty;
        [StringLength(4)] public string dclsts { get; set; } = string.Empty;
        [StringLength(2)] public string ispcde { get; set; } = string.Empty;
        [StringLength(13)] public string refnum { get; set; } = string.Empty;
        public decimal vernum { get; set; }
        [StringLength(1)] public string doctyp { get; set; } = string.Empty;
        [StringLength(17)] public string cmptaxnum { get; set; } = string.Empty;
        public decimal cmpbrn { get; set; }
        [StringLength(120)] public string cmpnme { get; set; } = string.Empty;
        [StringLength(70)] public string cmpnmeeng { get; set; } = string.Empty;
        [StringLength(70)] public string adr { get; set; } = string.Empty;
        [StringLength(35)] public string tmbnme { get; set; } = string.Empty;
        [StringLength(35)] public string ampnme { get; set; } = string.Empty;
        [StringLength(35)] public string prvnme { get; set; } = string.Empty;
        [StringLength(9)] public string poscde { get; set; } = string.Empty;
        [StringLength(17)] public string bkrtaxnum { get; set; } = string.Empty;
        public decimal bkrbrn { get; set; }
        [StringLength(17)] public string cusclrcrd { get; set; } = string.Empty;
        [StringLength(35)] public string cusclrnme { get; set; } = string.Empty;
        [StringLength(17)] public string mgrnum { get; set; } = string.Empty;
        [StringLength(35)] public string mgrnme { get; set; } = string.Empty;
        [StringLength(1)] public string tspmde { get; set; } = string.Empty;
        [StringLength(1)] public string pkgtyp { get; set; } = string.Empty;
        [StringLength(35)] public string vslnme { get; set; } = string.Empty;
        public decimal dtearv { get; set; }
        [StringLength(35)] public string masbil { get; set; } = string.Empty;
        [StringLength(35)] public string houbil { get; set; } = string.Empty;
        public decimal etbnum { get; set; }
        public decimal facnum { get; set; }
        public decimal potrea { get; set; }
        public decimal potdis { get; set; }
        [StringLength(2)] public string ctyogn { get; set; } = string.Empty;
        [StringLength(2)] public string ctycsn { get; set; } = string.Empty;
        [StringLength(512)] public string shpmrk { get; set; } = string.Empty;
        public decimal totpkgamt { get; set; }
        [StringLength(3)] public string pkgunt { get; set; } = string.Empty;
        public decimal wgt { get; set; }
        [StringLength(3)] public string wgtunt { get; set; } = string.Empty;
        public decimal wgtgos { get; set; }
        [StringLength(3)] public string wgtgosunt { get; set; } = string.Empty;
        [StringLength(3)] public string cuc { get; set; } = string.Empty;
        public decimal ehr { get; set; }
        public decimal cifvalfor { get; set; }
        public decimal cifvalthb { get; set; }
        public decimal rgscde { get; set; }
        public decimal rtcbnkcde { get; set; }
        public decimal bnkcde { get; set; }
        public decimal brncde { get; set; }
        [StringLength(35)] public string bnkaccnum { get; set; } = string.Empty;
        public decimal pmtamt { get; set; }
        [StringLength(1)] public string pmtmtd { get; set; } = string.Empty;
        public decimal tottax { get; set; }
        public decimal totdps { get; set; }
        [StringLength(35)] public string refcomacs { get; set; } = string.Empty;
        [StringLength(1)] public string asmreq { get; set; } = string.Empty;
        [StringLength(1)] public string ispreq { get; set; } = string.Empty;
        public decimal dtedpt { get; set; }
        public decimal potapr { get; set; }
        public decimal aprnum { get; set; }
        [StringLength(35)] public string ediuid { get; set; } = string.Empty;
        public decimal dteprs { get; set; }
        public decimal tmeprs { get; set; }
        public decimal dteldg { get; set; }
        public decimal tmeldg { get; set; }
        public decimal dtepmt { get; set; }
        [StringLength(6)] public string uidasm { get; set; } = string.Empty;
        public decimal dteasm { get; set; }
        public decimal tmeasm { get; set; }
        public decimal dterea { get; set; }
        public decimal tmerea { get; set; }
        public decimal dteaud { get; set; }
        public decimal tmeaud { get; set; }
        public decimal dtelod { get; set; }
        public decimal tmelod { get; set; }
        [StringLength(1)] public string ldgtyp { get; set; } = string.Empty;
        [StringLength(6)] public string uidupd { get; set; } = string.Empty;
        public decimal dteupd { get; set; }
        public decimal tmeupd { get; set; }
        [StringLength(6)] public string uidamn { get; set; } = string.Empty;
        public DateTime? dtetmeamn { get; set; }
        [StringLength(1)] public string mnt { get; set; } = string.Empty;
        [StringLength(17)] public string cataxnum1 { get; set; } = string.Empty;
        [StringLength(17)] public string cataxnum2 { get; set; } = string.Empty;
        public decimal totpkgfgn { get; set; }
        [StringLength(1)] public string grtmtd { get; set; } = string.Empty;
        [StringLength(1)] public string grttyp { get; set; } = string.Empty;
        public decimal grtbnkcde { get; set; }
        public decimal grtbrncde { get; set; }
        [StringLength(35)] public string grtaccnum { get; set; } = string.Empty;
        public decimal dpsamt { get; set; }
        [StringLength(17)] public string exptaxictid { get; set; } = string.Empty;
        [StringLength(17)] public string trdcmptaxnum { get; set; } = string.Empty;
        public decimal trdcmpbrn { get; set; }
        [StringLength(17)] public string subbrktaxnum { get; set; } = string.Empty;
        [StringLength(5)] public string dfrpmt { get; set; } = string.Empty;
        public decimal taxcrdbnkcde { get; set; }
        public decimal taxcrdbrncde { get; set; }
        [StringLength(35)] public string taxcrdaccnum { get; set; } = string.Empty;
        public decimal taxcrdamt { get; set; }
        public DateTime? ingdte { get; set; }
        public int ingyer { get; set; }
        public int ingmth { get; set; }
        public int ingday { get; set; }
        [StringLength(2)] public string dclyer { get; set; } = string.Empty;
        [StringLength(2)] public string dclmth { get; set; } = string.Empty;
    }
}
