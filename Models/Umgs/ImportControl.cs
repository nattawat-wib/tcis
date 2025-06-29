using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace tcirs_service.Models.Umgs
{
    [Table("import_control", Schema = "ugms")]
    public class ImportControl
    {
        [Key] 
        public int ID { get; set; }
        [StringLength(4)] public string IMPLodgedPort { get; set; } = string.Empty;
        [StringLength(10)] public string IMPDeclarationNumber { get; set; } = string.Empty;
        [StringLength(4)] public string DeclarationStatus { get; set; } = string.Empty;
        [StringLength(2)] public string InspectionCode { get; set; } = string.Empty;
        [StringLength(13)] public string ReferenceNo { get; set; } = string.Empty;
        public int VersionNumber { get; set; }
        [StringLength(1)] public string DocumentType { get; set; } = string.Empty;
        [StringLength(17)] public string CompanyTaxNo { get; set; } = string.Empty;
        public int CompanyBranch { get; set; }
        [StringLength(70)] public string CompanyName { get; set; } = string.Empty;
        [StringLength(70)] public string CompanyEnglishName { get; set; } = string.Empty;
        [StringLength(70)] public string CompanyAddress { get; set; } = string.Empty;
        [StringLength(70)] public string District { get; set; } = string.Empty;
        [StringLength(35)] public string SubProvince { get; set; } = string.Empty;
        [StringLength(35)] public string Province { get; set; } = string.Empty;
        [StringLength(9)] public string Postcode { get; set; } = string.Empty;
        [StringLength(17)] public string BrokerTaxNumber { get; set; } = string.Empty;
        public int BrokerBranch { get; set; }
        [StringLength(17)] public string CustomsClearanceCard { get; set; } = string.Empty;
        [StringLength(35)] public string CustomsClearanceName { get; set; } = string.Empty;
        [StringLength(17)] public string ManagerNumber { get; set; } = string.Empty;
        [StringLength(35)] public string ManagerName { get; set; } = string.Empty;
        [StringLength(1)] public string TransportMode { get; set; } = string.Empty;
        [StringLength(1)] public string CargoPackingType { get; set; } = string.Empty;
        [StringLength(35)] public string VasselName { get; set; } = string.Empty;
        public int ArrivalDate { get; set; }
        [StringLength(35)] public string MasterBillofLanding { get; set; } = string.Empty;
        [StringLength(35)] public string HouseBillofLanding { get; set; } = string.Empty;
        public int EstablishNO { get; set; }
        public int FactoryNo { get; set; }
        public int ReleasePort { get; set; }
        public int DischargePort { get; set; }
        [StringLength(2)] public string OriginalCountry { get; set; } = string.Empty;
        [StringLength(2)] public string ConsignmentCountry { get; set; } = string.Empty;
        [StringLength(512)] public string ShippinfMask { get; set; } = string.Empty;
        public int TotalPackageAmount { get; set; }
        [StringLength(3)] public string TotalPackageUnit { get; set; } = string.Empty;
        public decimal NetWeight { get; set; }
        [StringLength(3)] public string NetWeightUnit { get; set; } = string.Empty;
        public decimal GrossWeight { get; set; }
        [StringLength(3)] public string GrossWeightUnit { get; set; } = string.Empty;
        public DateTime CreatedDate { get; set; }
        [StringLength(100)] public string CreatedBy { get; set; } = string.Empty;
        public DateTime? UpdatedDate { get; set; }
        [StringLength(100)] public string UpdatedBy { get; set; } = string.Empty;
    }
}
