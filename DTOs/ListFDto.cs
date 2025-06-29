using Newtonsoft.Json;
using System.ComponentModel;

namespace tcirs_service.DTOs
{
    public class SummaryPage201Model
    {
        public int ListF { get; set; } = 0;
        public int IssueNoti { get; set; } = 0;
        public int ReplyBook { get; set; } = 0;
        public int CompleteNoti { get; set; } = 0;
    }
    public class ListFPage201Model
    {
        public int Id { get; set; }

        [Description("เลขที่ใบตราส่งสินค้า (Bill of Landing)")]
        public string HouseBillofLanding { get; set; } = string.Empty;
        [Description("ระยะเวลาเกินกำหนด (Over Time Good)")]
        public string DaysOverdue { get; set; } = string.Empty;
        [Description("วันที่นำเข้า (Arrive Date)")]
        public string ArriveDate { get; set; } = string.Empty;
        [Description("ชื่อยานพาหนะ (Vassel Name)")]
        public string VasselName { get; set; } = string.Empty;
        [Description("วันที่ติด List A")]
        public string ListFDate { get; set; } = string.Empty;
        [Description("ชื่อผู้นำเข้า (Consignee Name)")]
        public string CompanyName { get; set; } = string.Empty;
        [Description("สถานะ")]
        public string ImportStatus { get; set; } = string.Empty;
    }
    public class NotiPage201Model
    {
        public string BilLOfLanding { get; set; } = string.Empty;
        public string ReleaseDay { get; set; } = string.Empty;
        public string Houbil { get; set; } = string.Empty;
        public string Vslnme { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;
    }

    public class Page201Model
    {
        public SummaryPage201Model Summary { get; set; } = new SummaryPage201Model();
        public List<ListFPage201Model> ListF { get; set; } = new List<ListFPage201Model>();
        public List<NotiPage201Model> Noti { get; set; } = new List<NotiPage201Model>();
        public int NotiCount { get; set; } = 0;
    }


    public class SummaryPage202Model
    {
        public int ListF { get; set; } = 0;
        public int OpenSurvey { get; set; } = 0;
        public int RestrictedGoods { get; set; } = 0;
        public int DepositAtWarehouses { get; set; } = 0;
    }

    public class Page202Model
    {
        public List<ListFPage202Model> ListF { get; set; } = new List<ListFPage202Model>();
    }

    public class ListFPage202Model
    {
        public int Id { get; set; }
        public string RefNum { get; set; } = string.Empty;
        public string ArriveDate { get; set; } = string.Empty;
        public string ListFDate { get; set; } = string.Empty;
        public string DaysOverdue { get; set; } = string.Empty;
        public string VasselName { get; set; } = string.Empty;
        public string CompanyName { get; set; } = string.Empty;
        public string HouseBillofLanding { get; set; } = string.Empty;
        public string ShippinfMask { get; set; } = string.Empty;
        public string ImpDeclarationNumber { get; set; } = string.Empty;
        public string TotalPackageAmount { get; set; } = string.Empty;
        public string ImpStatus { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;
        public List<SubListFModel> SubListF { get; set; } = new List<SubListFModel>();
    }

    public class SubListFModel
    {
        public int Id { get; set; }
        public string ImpDclNum { get; set; } = string.Empty;
        public string VasselName { get; set; } = string.Empty;
        public int? DischargePort { get; set; }
        public string ArriveDate { get; set; } = string.Empty;
        public int? TotalPackage { get; set; }
        public string PackageUnit { get; set; } = string.Empty;
        public decimal? NetWeight { get; set; }
        public string NetWeightUnit { get; set; } = string.Empty;
        public string ReleaseLocationCode { get; set; } = string.Empty;
    }

    public class ModalListFPage202Model
    {
        public int Id { get; set; }
        public DateTime ArriveDate { get; set; }
        public string CompanyName { get; set; } = string.Empty;
        public string VasselName { get; set; } = string.Empty;
        public int ImpStatus { get; set; }
        public string ShippingMark { get; set; } = string.Empty;
        public string TotalPackage { get; set; } = string.Empty;
        public string PackageUnit { get; set; } = string.Empty;
        public List<ModalSubListFPage202Model> SubList { get; set; } = new List<ModalSubListFPage202Model>();
    }

    public class ModalSubListFPage202Model
    {
        public int Id { get; set; }
        public DateTime ArriveDate { get; set; }
        public string CompanyName { get; set; } = string.Empty;
        public string VasselName { get; set; } = string.Empty;
        public int ImpStatus { get; set; }
        public string ShippingMark { get; set; } = string.Empty;
        public string TotalPackage { get; set; } = string.Empty;
        public string PackageUnit { get; set; } = string.Empty;
        public string HouseBill { get; set; } = string.Empty;
        public string ProductCode { get; set; } = string.Empty;
        public string ProductNameTh { get; set; } = string.Empty;
        public string ProductNameEn { get; set; } = string.Empty;
        public string Weight { get; set; } = string.Empty;
        public string WeightUnit { get; set; } = string.Empty;
    }


    public class InsertPage202Model
    {
        public int Id { get; set; }
        public string ImportRefNo { get; set; } = string.Empty;
        public string DocumentNo { get; set; } = string.Empty;
        public string DocumentType { get; set; } = string.Empty;
        public int ReleaseDepartment { get; set; } = 300;
        public DateTime ReleaseDate { get; set; }
        public int ReleaseBy { get; set; } = 304;
        public int Status { get; set; } = 3;
        public string CreateBy { get; set; } = string.Empty;
        public DateTime CreateDate { get; set; } = DateTime.Now;
        public DateTime? ReciveDate { get; set; }
        public string ReciveBy { get; set; } = string.Empty;
        public int? ReleaseDay { get; set; } = 0;
        public List<RecipientModel> Recipients { get; set; } = new List<RecipientModel>();
    }
    public class RecipientModel
    {
        [JsonProperty("recipient_type")]
        public string RecipientType { get; set; } = string.Empty;
        [JsonProperty("recipient_name")]
        public string RecipientName { get; set; } = string.Empty;
        [JsonProperty("recipient_address")]
        public string RecipientAddress { get; set; } = string.Empty;
    }

    public class Page203Model
    {
        public int Id { get; set; }
        public string RefNum { get; set; } = string.Empty;
        public DateTime ArriveDate { get; set; }
        public string VasselName { get; set; } = string.Empty;
        public string CompanyName { get; set; } = string.Empty;
        public string DocumentNo { get; set; } = string.Empty;
        public DateTime ReleaseDate { get; set; }
        public string HouseofBilling { get; set; } = string.Empty;
        public string ShippingMark { get; set; } = string.Empty;
        public string Package { get; set; } = string.Empty;
        public string ProductDesc { get; set; } = string.Empty;
        public string Potldg { get; set; } = string.Empty;
    }
    public class Page204Model
    {
        public int Id { get; set; }
        public string DocumentNo { get; set; } = string.Empty;
        public string DocumentName { get; set; } = string.Empty;
        public DateTime ReleaseDate { get; set; }
        public int ReleaseDay { get; set; }
        public string ReleaseBy { get; set; } = string.Empty;
        public string ConsineeName { get; set; } = string.Empty;
        public string Vasselname { get; set; } = string.Empty;
        public string FullName { get; set; } = string.Empty;
        public string StatusName { get; set; } = string.Empty;
        public string ImportRefNo { get; set; } = string.Empty;
    }

    public class Page205Model
    {
        public int Id { get; set; }
        public string ImportRefNo { get; set; } = string.Empty;
        public string RefDocListF { get; set; } = string.Empty;
        public string DocumentType { get; set; } = string.Empty;
        public string ReleaseDepartment { get; set; } = string.Empty;
        public DateTime ReleaseDate { get; set; }
        public string ReleaseBy { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;
        public string CreateBy { get; set; } = string.Empty;
    }

    public class ModalListFPage205Model
    {
        public string refNum { get; set; } = string.Empty;
        public string vasselName { get; set; } = string.Empty;
        public string companyName { get; set; } = string.Empty;
        public string documentNo { get; set; } = string.Empty;
        public string releaseDate { get; set; } = string.Empty;
        public string houseOfBilling { get; set; } = string.Empty;
        public string shipingMask { get; set; } = string.Empty;
        public string productDescEn { get; set; } = string.Empty;
        public string productDescTh { get; set; } = string.Empty;
        public string productCode { get; set; } = string.Empty;
        public string potldg { get; set; } = string.Empty;
        public string quantity { get; set; } = string.Empty;
        public string quantityUnit { get; set; } = string.Empty;
    }

    public class SummaryPage204Model
    {
        public int NotiDueDate { get; set; } = 0;
        public int IssueLetter { get; set; } = 0;
        public int NotiWarehouses { get; set; } = 0;
        public int Exemption { get; set; } = 0;
        public int Progress { get; set; } = 0;
    }

    public class Page206Model
    {
        public string Refnum { get; set; } = string.Empty;
        public string Vasselname { get; set; } = string.Empty;
        public string Companyname { get; set; } = string.Empty;
        public string Documentno { get; set; } = string.Empty;
        public string Fullname { get; set; } = string.Empty;
        public string Department { get; set; } = string.Empty;
    }
    public class ListFRunningNumber
    {
        public string RunningNumber { get; set; } = string.Empty;
    }

    public class Page215Model
    {
        public string p_house_bl { get; set; } = string.Empty;
        public string p_vassel_name { get; set; } = string.Empty;
        public string p_company { get; set; } = string.Empty;
        public string p_package { get; set; } = string.Empty;
        public string p_weight { get; set; } = string.Empty;
        public string p_importno { get; set; } = string.Empty;
        public string p_listfdate { get; set; } = string.Empty;
        public string p_status { get; set; } = string.Empty;
    }
}
