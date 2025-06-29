using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace tcirs_service.Models.Umgs
{
    [Table("import_detail", Schema = "imp")]
    public class ImportDetail
    {
        [Key] public int ItemNumber { get; set; }

        public int? IMPDeclarationLineNumber { get; set; }
        [StringLength(35)] public string? OriginCriteria { get; set; }
        [StringLength(17)] public string? ModelCompanyTaxNumber { get; set; }
        public int? AddNumber { get; set; }
        public int? ArgumentativeTariffCode { get; set; }
        public int? ArgumentativeTariffSequence { get; set; }
        public int? EXPDeclarationLineNumber { get; set; }
        public decimal? QuantityForgone { get; set; }
        [StringLength(2)] public string? OriginCountry { get; set; }
        public int? ExciseNumber { get; set; }
        [StringLength(3)] public string? PrivilegeCode { get; set; }
        public int? InvoiceItem { get; set; }
        public decimal? UnitPriceBaht { get; set; }
        [StringLength(10)] public string? EXPDeclarationNumber { get; set; }
        [StringLength(12)] public string? ImportTariff { get; set; }
        [StringLength(17)] public string? CertifiedExporterNumber { get; set; }
        public int? ModelVersion { get; set; }
        public int? NatureOfTransaction { get; set; }
        public int? PackageAmount { get; set; }
        public int? ProductYear { get; set; }
        public int? StatisticalCode { get; set; }
        public int? TariffClassification { get; set; }
        public int? TariffSequence { get; set; }
        public int? UNDGNumber { get; set; }
        public int? ValuationCode { get; set; }
        [StringLength(6)] public string? AmendUserID { get; set; }
        [StringLength(35)] public string? ProductAttribute1 { get; set; }
        [StringLength(17)] public string? ImportTaxIncentiveID { get; set; }
        [Column(TypeName = "char(1)")] public string? Bond { get; set; }
        [StringLength(35)] public string? ProductAttribute2 { get; set; }
        public decimal? UnitPriceForeign { get; set; }
        public decimal? Weight { get; set; }
        [StringLength(3)] public string? QuantityUnit { get; set; }
        [StringLength(12)] public string? AHTNCode { get; set; }
        public DateTime? AmendDateTime { get; set; }
        [StringLength(3)] public string? ArgumentativePrivilegeCode { get; set; }
        [StringLength(3)] public string? ArgumentativeReason { get; set; }
        public decimal? AssessExciseQuantity { get; set; }
        public decimal? AssessQuantity { get; set; }
        [StringLength(1)] public string? BOI { get; set; }
        [StringLength(35)] public string? BOILicenseNumber { get; set; }
        [StringLength(1)] public string? Bis19 { get; set; }
        [StringLength(35)] public string? BrandName { get; set; }
        public decimal? CIFValueAssess { get; set; }
        public decimal? CIFValueBaht { get; set; }
        public decimal? CIFValueBahtForgone { get; set; }
        public decimal? CIFValueForeign { get; set; }
        public decimal? CIFValueForeignForgone { get; set; }
        [StringLength(100)] public string? CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        [StringLength(3)] public string? CurrencyCode { get; set; }
        [Column(TypeName = "char(35)")] public string? CustomsProductCode { get; set; }
        public decimal? DeductedAmount { get; set; }
        [StringLength(3)] public string? DepositReason { get; set; }
        [StringLength(512)] public string? DescriptionOfGoodsEnglish { get; set; }
        [Column(TypeName = "char(512)")] public string? DescriptionOfGoodsThai { get; set; }
        [StringLength(4)] public string? EXPLodgedPort { get; set; }
        public decimal? ExchangeRate { get; set; }
        public decimal? ExciseQuantity { get; set; }
        [StringLength(3)] public string? ExciseQuantityUnit { get; set; }
        public decimal? ExemptionCIFBaht { get; set; }
        public decimal? ForgoneWeight { get; set; }
        [StringLength(1)] public string? FreeZone { get; set; }
        public decimal? GrossWeight { get; set; }
        [StringLength(1)] public string? IEATFreeZone { get; set; }
        [StringLength(10)] public string? IMPDeclarationNumber { get; set; }
        [StringLength(4)] public string? IMPLodgedPort { get; set; }
        public decimal? IncreasedPriceBaht { get; set; }
        public decimal? IncreasedPriceForeign { get; set; }
        public decimal? InvoiceAmountBaht { get; set; }
        public decimal? InvoiceAmountForeign { get; set; }
        [StringLength(35)] public string? InvoiceNumber { get; set; }
        public decimal? InvoiceQuantity { get; set; }
        [StringLength(3)] public string? InvoiceQuantityUnit { get; set; }
        [StringLength(1)] public string? Maint { get; set; }
        [StringLength(35)] public string? ModelNumber { get; set; }
        [StringLength(3)] public string? PackageUnit { get; set; }
        [StringLength(7)] public string? ProcedureCode { get; set; }
        [Column(TypeName = "char(35)")] public string? ProductCode { get; set; }
        public decimal? Quantity { get; set; }
        [StringLength(1)] public string? ReExport { get; set; }
        [StringLength(1)] public string? ReImportationCertificate { get; set; }
        [StringLength(256)] public string? Remark { get; set; }
        [StringLength(1)] public string? Royalty { get; set; }
        [StringLength(1)] public string? RoyaltyCode { get; set; }
        [StringLength(1)] public string? Several { get; set; }
        [StringLength(512)] public string? ShippingMark { get; set; }
        [StringLength(1)] public string? Status { get; set; }
        [StringLength(100)] public string? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        [Column(TypeName = "char(3)")] public string? WeightUnit { get; set; }
    }
}
