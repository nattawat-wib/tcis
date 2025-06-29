using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace tcirs_service.Models.Umgs
{
    [Table("import_list_a", Schema = "ugms")]
    public class ImportListA
    {
        [Key]
        [Column("listid")]
        public int ListId { get; set; }

        [Column("impdclnum")]
        public string ImpDclNum { get; set; } = string.Empty;

        [Column("importrefno")]
        public string ImportRefNo { get; set; } = string.Empty;

        [Column("department")]
        public string Department { get; set; } = string.Empty;

        [Column("listadate")]
        public DateTime? ListaDate { get; set; }

        [Column("casefileno")]
        public string CaseFileNo { get; set; } = string.Empty;

        [Column("daysinlista")]
        public int DaysInLista { get; set; }

        [Column("status")]
        public string Status { get; set; } = string.Empty;

        [Column("createdby")]
        public string CreatedBy { get; set; } = string.Empty;

        [Column("createddate")]
        public DateTime? CreatedDate { get; set; }

        [Column("updatedby")]
        public string UpdatedBy { get; set; } = string.Empty;

        [Column("updateddate")]
        public DateTime? UpdatedDate { get; set; }

        [Column("isdeleted")]
        public short IsDeleted { get; set; }
    }
}
