using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace tcirs_service.Models.Umgs
{
    [Table("import_vassel", Schema = "ugms")]
    public class ImportVassel
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }

        [Column("INDPRC")]
        [StringLength(2)]
        public string IndPrc { get; set; } = string.Empty;

        [Column("VSLRCVNUM")]
        [StringLength(17)]
        public string VslRcvNum { get; set; } = string.Empty;

        [Column("CALSGN")]
        [StringLength(35)]
        public string CalSgn { get; set; } = string.Empty;

        [Column("REFNUM")]
        [StringLength(13)]
        public string RefNum { get; set; } = string.Empty;

        [Column("DTESHD")]
        public int DteShd { get; set; }

        [Column("TMESHD")]
        public int TmeShd { get; set; }

        [Column("DTEACT")]
        public int DteAct { get; set; }

        [Column("TMEACT")]
        public int TmeAct { get; set; }

        [Column("VOYNUM")]
        [StringLength(17)]
        public string VoyNum { get; set; } = string.Empty;

        [Column("VSLNME")]
        [StringLength(35)]
        public string VslNme { get; set; } = string.Empty;

        [Column("TSPTYP")]
        public int TspTyp { get; set; }

        [Column("PRVFLTNUM")]
        [StringLength(17)]
        public string PrvFltNum { get; set; } = string.Empty;

        [Column("DTEPRV")]
        public int DtePrv { get; set; }

        [Column("VSLLSTSTS")]
        [StringLength(1)]
        public string VslLstSts { get; set; } = string.Empty;

        [Column("DTEVSLLST")]
        public int DteVslLst { get; set; }

        [Column("DTEARV")]
        public int DteArv { get; set; }

        [Column("SHPREFNUM")]
        [StringLength(12)]
        public string ShpRefNum { get; set; } = string.Empty;

        [Column("CTYOGN")]
        [StringLength(2)]
        public string CtyOgn { get; set; } = string.Empty;

        [Column("NATCTY")]
        [StringLength(2)]
        public string NatCty { get; set; } = string.Empty;

        [Column("GOSREGTON")]
        public decimal GosRegTon { get; set; }

        [Column("REGTON")]
        public decimal RegTon { get; set; }

        [Column("WGTDEDTON")]
        public decimal WgtDedTon { get; set; }

        [Column("CAPNME")]
        [StringLength(70)]
        public string CapNme { get; set; } = string.Empty;

        [Column("PKGAMT")]
        public int PkgAmt { get; set; }

        [Column("TOTMAS")]
        public int TotMas { get; set; }

        [Column("TOTHOU")]
        public int TotHou { get; set; }

        [Column("TOTCTR")]
        public int TotCtr { get; set; }

        [Column("POTDIS")]
        public int PotDis { get; set; }

        [Column("POTDISIPC")]
        [StringLength(5)]
        public string PotDisIpc { get; set; } = string.Empty;

        [Column("POTLODIPC")]
        [StringLength(5)]
        public string PotLodIpc { get; set; } = string.Empty;

        [Column("POTLASIPC")]
        [StringLength(5)]
        public string PotLasIpc { get; set; } = string.Empty;

        [Column("SHPCDE")]
        [StringLength(17)]
        public string ShpCde { get; set; } = string.Empty;

        [Column("TSPMDE")]
        [StringLength(1)]
        public string TspMde { get; set; } = string.Empty;

        [Column("PKGUNT")]
        [StringLength(3)]
        public string PkgUnt { get; set; } = string.Empty;

        [Column("WGTGOS")]
        public decimal WgtGos { get; set; }

        [Column("WGTGOSUNT")]
        [StringLength(3)]
        public string WgtGosUnt { get; set; } = string.Empty;

        [Column("MNT")]
        [StringLength(1)]
        public string Mnt { get; set; } = string.Empty;

        [Column("MSGFNC")]
        [StringLength(2)]
        public string MsgFnc { get; set; } = string.Empty;

        [Column("DTEXMT")]
        public int DteXmt { get; set; }

        [Column("TMEXMT")]
        public int TmeXmt { get; set; }

        [Column("UIDXMT")]
        [StringLength(35)]
        public string UidXmt { get; set; } = string.Empty;

        [Column("DTEAMN")]
        public int DteAmn { get; set; }

        [Column("TMEAMN")]
        public int TmeAmn { get; set; }

        [Column("UIDAMN")]
        [StringLength(6)]
        public string UidAmn { get; set; } = string.Empty;

        [Column("SCRAMN")]
        [StringLength(10)]
        public string ScrAmn { get; set; } = string.Empty;

        [Column("STNAMN")]
        [StringLength(17)]
        public string StnAmn { get; set; } = string.Empty;

        [Column("UIDVSL")]
        [StringLength(6)]
        public string UidVsl { get; set; } = string.Empty;

        [Column("EPNSTS")]
        [StringLength(1)]
        public string EpnSts { get; set; } = string.Empty;

        [Column("EPNDAY")]
        public int EpnDay { get; set; }

        [Column("DTEBTH")]
        public int DteBth { get; set; }

        [Column("TMEBTH")]
        public int TmeBth { get; set; }

        [Column("POTNEXIPC")]
        [StringLength(5)]
        public string PotNexIpc { get; set; } = string.Empty;

        [Column("BTHNUM")]
        [StringLength(5)]
        public string BthNum { get; set; } = string.Empty;

        [Column("SHPBRN")]
        public int ShpBrn { get; set; }

        [Column("SHPIMO")]
        [StringLength(10)]
        public string ShpImo { get; set; } = string.Empty;

        [Column("DTEXTR")]
        public DateTime DteXtr { get; set; }
    }
}
