using System.ComponentModel.DataAnnotations.Schema;

namespace tcirs_service.Models.Umgs
{
    [Table("overdue_result", Schema = "ugms")]
    public class OverdueResult
    {
        [Column("referenceno")]
        public string? ReferenceNo { get; set; }

        [Column("arrivedate")]
        public string? ArriveDate { get; set; }

        [Column("duedate")]
        public string? DueDate { get; set; }

        [Column("daysoverdue")]
        public string? DaysOverdue { get; set; }

        [Column("vasselname")]
        public string? VasselName { get; set; }

        [Column("companyname")]
        public string? CompanyName { get; set; }

        [Column("housebilloflanding")]
        public string? HouseBillOfLanding { get; set; }

        [Column("impdeclarationnumber")]
        public string? ImpDeclarationNumber { get; set; }

        [Column("implodgedport")]
        public string? ImpLodgedPort { get; set; }

        [Column("impstatus")]
        public string? ImpStatus { get; set; }

        [Column("loggedat")]
        public DateTime? LoggedAt { get; set; }
    }
}
