using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace tcirs_service.Models.Umgs
{
    [Table("send_doc_detail", Schema = "ugms")]
    public class SendDocDetail
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("listf_id")]
        public int ListfId { get; set; }

        [Column("vassel_name")]
        public string VasselName { get; set; } = null!;

        [Column("master_bl_no")]
        public string MasterBlNo { get; set; } = null!;

        [Column("house_bl_no")]
        public string HouseBlNo { get; set; } = null!;

        [Column("product_desc_en")]
        public string ProductDescEn { get; set; } = null!;

        [Column("product_desc_th")]
        public string ProductDescTh { get; set; } = null!;

        [Column("quantity")]
        public decimal Quantity { get; set; }

        [Column("quantity_unit")]
        public string QuantityUnit { get; set; } = null!;

        [Column("weight")]
        public decimal Weight { get; set; }

        [Column("weight_unit")]
        public string WeightUnit { get; set; } = null!;

        [Column("created_by")]
        public string CreatedBy { get; set; } = null!;

        [Column("created_date")]
        public DateTime CreatedDate { get; set; }

        [Column("updated_by")]
        public string UpdatedBy { get; set; } = null!;

        [Column("updated_date")]
        public DateTime UpdatedDate { get; set; }

        [Column("consinee_name")]
        public string ConsineeName { get; set; } = null!;

        [Column("status")]
        public string Status { get; set; } = null!;

        [Column("importdate")]
        public DateTime ImportDate { get; set; }
    }
}
