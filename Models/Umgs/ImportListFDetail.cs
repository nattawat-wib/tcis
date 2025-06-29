using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace tcirs_service.Models.Umgs
{
    [Table("import_list_f_detail", Schema = "ugms")]
    public class ImportListFDetail
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("listf_id")]
        public int ListFId { get; set; }

        [Column("vassel_name")]
        [StringLength(50)]
        public string VasselName { get; set; } = string.Empty;

        [Column("master_bl_no")]
        [StringLength(50)]
        public string MasterBlNo { get; set; } = string.Empty;

        [Column("house_bl_no")]
        [StringLength(50)]
        public string HouseBlNo { get; set; } = string.Empty;

        [Column("product_desc_en")]
        [StringLength(255)]
        public string ProductDescEn { get; set; } = string.Empty;

        [Column("product_desc_th")]
        public string ProductDescTh { get; set; } = string.Empty;

        [Column("quantity")]
        [Precision(10, 2)]
        public decimal Quantity { get; set; }

        [Column("quantity_unit")]
        [StringLength(10)]
        public string QuantityUnit { get; set; } = string.Empty;

        [Column("weight")]
        [Precision(10, 2)]
        public decimal Weight { get; set; }

        [Column("weight_unit")]
        [StringLength(10)]
        public string WeightUnit { get; set; } = string.Empty;

        [Column("created_by")]
        [StringLength(100)]
        public string CreatedBy { get; set; } = string.Empty;

        [Column("created_date")]
        public DateTime CreatedDate { get; set; }

        [Column("updated_by")]
        [StringLength(100)]
        public string UpdatedBy { get; set; } = string.Empty;

        [Column("updated_date")]
        public DateTime UpdatedDate { get; set; }

        [Column("consinee_name")]
        [StringLength(255)]
        public string ConsineeName { get; set; } = string.Empty;

        [Column("status")]
        [StringLength(255)]
        public string Status { get; set; } = string.Empty;

        [Column("importdate")]
        public DateTime ImportDate { get; set; }
    }
}
