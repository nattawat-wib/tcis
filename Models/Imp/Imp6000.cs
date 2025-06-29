using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace tcirs_service.Models.Imp
{
    [Table("imp6000", Schema = "imp")]
    public class Imp6000
    {
        [Key] // Assuming indprc is unique; otherwise you can add composite keys or remove this
        [StringLength(2)]
        public string indprc { get; set; } = string.Empty;

        [StringLength(17)]
        public string vslrcvnum { get; set; } = string.Empty;

        [StringLength(35)]
        public string calsgn { get; set; } = string.Empty;

        [StringLength(13)]
        public string refnum { get; set; } = string.Empty;

        public int dteshd { get; set; }
        public int tmeshd { get; set; }
        public int dteact { get; set; }
        public int tmeact { get; set; }

        [StringLength(17)]
        public string voynum { get; set; } = string.Empty;

        [StringLength(35)]
        public string vslnme { get; set; } = string.Empty;

        [StringLength(2)]
        public string tsptyp { get; set; } = string.Empty;

        [StringLength(17)]
        public string prvfltnum { get; set; } = string.Empty;

        public int dteprv { get; set; }

        [StringLength(1)]
        public string vsllststs { get; set; } = string.Empty;

        public int dtevsllst { get; set; }
        public int dtearv { get; set; }

        [StringLength(12)]
        public string shprefnum { get; set; } = string.Empty;

        [StringLength(2)]
        public string ctyogn { get; set; } = string.Empty;

        [StringLength(2)]
        public string natcty { get; set; } = string.Empty;

        [Column(TypeName = "numeric(14,3)")]
        public decimal gosregton { get; set; }

        [Column(TypeName = "numeric(14,3)")]
        public decimal regton { get; set; }

        [Column(TypeName = "numeric(14,3)")]
        public decimal wgtdedton { get; set; }

        [StringLength(70)]
        public string capnme { get; set; } = string.Empty;

        public int pkgamt { get; set; }
        public int totmas { get; set; }
        public int tothou { get; set; }
        public int totctr { get; set; }
        public int potdis { get; set; }

        [StringLength(5)]
        public string potdisipc { get; set; } = string.Empty;

        [StringLength(5)]
        public string potlodipc { get; set; } = string.Empty;

        [StringLength(5)]
        public string potlasipc { get; set; } = string.Empty;

        [StringLength(17)]
        public string shpcde { get; set; } = string.Empty;

        [StringLength(1)]
        public string tspmde { get; set; } = string.Empty;

        [StringLength(3)]
        public string pkgunt { get; set; } = string.Empty;

        [Column(TypeName = "numeric(11,3)")]
        public decimal wgtgos { get; set; }

        [StringLength(3)]
        public string wgtgosunt { get; set; } = string.Empty;

        [StringLength(1)]
        public string mnt { get; set; } = string.Empty;

        [StringLength(2)]
        public string msgfnc { get; set; } = string.Empty;

        public int dtexmt { get; set; }
        public int tmexmt { get; set; }

        [StringLength(35)]
        public string uidxmt { get; set; } = string.Empty;

        public int dteamn { get; set; }
        public int tmeamn { get; set; }

        [StringLength(6)]
        public string uidamn { get; set; } = string.Empty;

        [StringLength(10)]
        public string scramn { get; set; } = string.Empty;

        [StringLength(17)]
        public string stnamn { get; set; } = string.Empty;

        [StringLength(6)]
        public string uidvsl { get; set; } = string.Empty;

        [StringLength(1)]
        public string epnsts { get; set; } = string.Empty;

        public int epnday { get; set; }
        public int dtebth { get; set; }
        public int tmebth { get; set; }

        [StringLength(5)]
        public string potnexipc { get; set; } = string.Empty;

        [StringLength(5)]
        public string bthnum { get; set; } = string.Empty;

        public int shpbrn { get; set; }

        [StringLength(10)]
        public string shpimo { get; set; } = string.Empty;

        public DateTime ingdte { get; set; }

        public int ingyer { get; set; }
        public int ingmth { get; set; }
        public int ingday { get; set; }

        [StringLength(2)]
        public string dclyer { get; set; } = string.Empty;

        [StringLength(2)]
        public string dclmth { get; set; } = string.Empty;
    }
}
