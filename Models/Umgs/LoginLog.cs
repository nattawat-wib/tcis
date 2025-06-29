using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace tcirs_service.Models.Umgs
{
    [Table("loginlog", Schema = "ugms")]
    public class LoginLog
    {
        [Key]
        [Column("logid")]
        public int LogId { get; set; }

        [Column("userid")]
        public int UserId { get; set; }

        [Column("emailattempted")]
        [StringLength(255)]
        public string EmailAttempted { get; set; } = string.Empty;

        [Column("logintime")]
        public DateTime LoginTime { get; set; }

        [Column("ipaddress")]
        [StringLength(45)]
        public string IpAddress { get; set; } = string.Empty;

        [Column("useragent")]
        public string UserAgent { get; set; } = string.Empty;

        [Column("loginresult")]
        [StringLength(10)]
        public string LoginResult { get; set; } = string.Empty;

        [Column("failreason")]
        public string? FailReason { get; set; }
    }
}
