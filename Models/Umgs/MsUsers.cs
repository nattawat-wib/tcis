using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace tcirs_service.Models.Umgs
{
    [Table("msusers", Schema = "ugms")]
    public class MsUsers
    {
        [Key]
        [Column("userid")]
        public int UserId { get; set; }

        [Column("externalid")]
        public string? ExternalId { get; set; }

        [Column("email")]
        public string? Email { get; set; }

        [Required]
        [Column("username")]
        public string Username { get; set; } = null!;

        [Required]
        [Column("fullname")]
        public string FullName { get; set; } = null!;

        [Column("provider")]
        public string? Provider { get; set; }

        [Required]
        [Column("department")]
        public string Department { get; set; } = null!;

        [Column("pictureurl")]
        public string? PictureUrl { get; set; }

        [Column("lastlogin")]
        public DateTime? LastLogin { get; set; }

        [Required]
        [Column("isactive")]
        public bool IsActive { get; set; }

        [Column("createdat")]
        public DateTime? CreatedAt { get; set; }

        [Column("updatedat")]
        public DateTime? UpdatedAt { get; set; }
    }
}
