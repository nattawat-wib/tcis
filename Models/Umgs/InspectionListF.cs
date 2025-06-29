using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace tcirs_service.Models.Umgs
{
    [Table("inspection_listf", Schema = "ugms")]
    public class InspectionListF
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("importrefno")]
        [StringLength(50)]
        public string ImportRefNo { get; set; } = string.Empty;

        [Column("product_type")]
        [StringLength(100)]
        public string ProductType { get; set; } = string.Empty;

        [Column("packaging_quantity")]
        [StringLength(50)]
        public string? PackagingQuantity { get; set; }

        [Column("quantity_kg")]
        public decimal QuantityKg { get; set; }

        [Column("estimated_price")]
        public decimal EstimatedPrice { get; set; }

        [Column("total_tax")]
        public decimal TotalTax { get; set; }

        [Column("product_condition")]
        [StringLength(100)]
        public string? ProductCondition { get; set; }

        [Column("action_plan")]
        [StringLength(100)]
        public string? ActionPlan { get; set; }

        [Column("inspector_name")]
        [StringLength(100)]
        public string? InspectorName { get; set; }

        [Column("inspection_date")]
        public DateTime InspectionDate { get; set; }

        [Column("document_link")]
        [StringLength(255)]
        public string? DocumentLink { get; set; }

        [Column("created_at")]
        public DateTime CreatedAt { get; set; }

        [Column("prohibited_good")]
        public int ProhibitedGood { get; set; }
    }
}
