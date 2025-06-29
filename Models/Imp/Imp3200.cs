using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace tcirs_service.Models.Imp
{
    [Table("imp3200", Schema = "imp")]
    public class Imp3200
    {
        [Key, StringLength(4)] public string potldg { get; set; } = string.Empty;
        [StringLength(10)] public string impdclnum { get; set; } = string.Empty;
        public int dcllnenum { get; set; }
        [StringLength(35)] public string ivcnum { get; set; } = string.Empty;
        public int ivcitmnum { get; set; }
        public int trfcls { get; set; }
        public int trfseq { get; set; }
        public int trscde { get; set; }
        [StringLength(12)] public string trfimp { get; set; } = string.Empty;
        [StringLength(3)] public string pvlcde { get; set; } = string.Empty;
        public int ahtncde { get; set; }
        [StringLength(3)] public string dpsrsn { get; set; } = string.Empty;
        public int txntyp { get; set; }
        public int undgnum { get; set; }
        [StringLength(35)] public string prdcde { get; set; } = string.Empty;
        [StringLength(512)] public string gdsdsc { get; set; } = string.Empty;
        [StringLength(512)] public string gdsdscth { get; set; } = string.Empty;
        [StringLength(35)] public string rtcprdcde { get; set; } = string.Empty;
        [StringLength(35)] public string prdatb1 { get; set; } = string.Empty;
        [StringLength(35)] public string prdatb2 { get; set; } = string.Empty;
        public int prdyer { get; set; }
        [StringLength(35)] public string bannme { get; set; } = string.Empty;
        [StringLength(256)] public string rmk { get; set; } = string.Empty;
        [StringLength(2)] public string ctyogn { get; set; } = string.Empty;
        public decimal wgt { get; set; }
        [StringLength(3)] public string wgtunt { get; set; } = string.Empty;
        public decimal qty { get; set; }
        [StringLength(3)] public string qtyunt { get; set; } = string.Empty;
        [StringLength(3)] public string cuc { get; set; } = string.Empty;
        public decimal ehr { get; set; }
        public decimal pcefor { get; set; }
        public decimal pcethb { get; set; }
        public decimal qtyivc { get; set; }
        [StringLength(3)] public string qtyivcunt { get; set; } = string.Empty;
        public decimal amtfor { get; set; }
        public decimal amtthb { get; set; }
        public decimal pceicrfor { get; set; }
        public decimal pceicrthb { get; set; }
        public decimal cifvalfor { get; set; }
        public decimal cifvalthb { get; set; }
        public decimal cifvalasm { get; set; }
        [StringLength(512)] public string shpmrk { get; set; } = string.Empty;
        public int pkgamt { get; set; }
        [StringLength(3)] public string pkgunt { get; set; } = string.Empty;
        [StringLength(1)] public string rimcer { get; set; } = string.Empty;
        [StringLength(1)] public string boiind { get; set; } = string.Empty;
        [StringLength(1)] public string bonind { get; set; } = string.Empty;
        [StringLength(1)] public string dbkind { get; set; } = string.Empty;
        [StringLength(1)] public string rimind { get; set; } = string.Empty;
        [StringLength(1)] public string fzind { get; set; } = string.Empty;
        [StringLength(1)] public string epzind { get; set; } = string.Empty;
        [StringLength(1)] public string svrshpind { get; set; } = string.Empty;
        [StringLength(4)] public string exppotldg { get; set; } = string.Empty;
        [StringLength(10)] public string expdclnum { get; set; } = string.Empty;
        public int expdcllne { get; set; }
        public decimal qtyasm { get; set; }
        public decimal emtcif { get; set; }
        public int ecsnum { get; set; }
        public decimal qtyecs { get; set; }
        [StringLength(3)] public string qtyecsunt { get; set; } = string.Empty;
        public decimal qtyecsasm { get; set; }
        [StringLength(6)] public string uidamn { get; set; } = string.Empty;
        public DateTime dtetmeamn { get; set; }
        [StringLength(1)] public string mnt { get; set; } = string.Empty;
        public decimal ciffgnfor { get; set; }
        public decimal ciffgnthb { get; set; }
        public decimal wgtfgn { get; set; }
        public decimal qtyfgn { get; set; }
        [StringLength(1)] public string sts { get; set; } = string.Empty;
        public int addnum { get; set; }
        public int itmnum { get; set; }
        [StringLength(17)] public string imptaxictid { get; set; } = string.Empty;
        public int argtrfcls { get; set; }
        public int argtrfseq { get; set; }
        [StringLength(3)] public string argpvlcde { get; set; } = string.Empty;
        [StringLength(35)] public string bqtnum { get; set; } = string.Empty;
        [StringLength(35)] public string ogncrt { get; set; } = string.Empty;
        [StringLength(17)] public string ctfexpnum { get; set; } = string.Empty;
        public decimal wgtgos { get; set; }
        [StringLength(7)] public string pcdcde { get; set; } = string.Empty;
        public int valcde { get; set; }
        public decimal decamt { get; set; }
        [StringLength(35)] public string mdlnum { get; set; } = string.Empty;
        public int mdlver { get; set; }
        [StringLength(17)] public string mdlcmptaxnum { get; set; } = string.Empty;
        [StringLength(1)] public string rytind { get; set; } = string.Empty;
        [StringLength(1)] public string rytcde { get; set; } = string.Empty;
        [StringLength(3)] public string argrsn { get; set; } = string.Empty;
        public DateTime ingdte { get; set; }
        public int ingyer { get; set; }
        public int ingmth { get; set; }
        public int ingday { get; set; }
        [StringLength(2)] public string dclyer { get; set; } = string.Empty;
        [StringLength(2)] public string dclmth { get; set; } = string.Empty;
    }
}
