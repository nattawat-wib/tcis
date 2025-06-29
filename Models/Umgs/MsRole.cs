using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace tcirs_service.Models.Umgs
{
    [Table("msrole", Schema = "ugms")]
    public class MsRole
    {
        [Key]
        [Column("roleid")]
        public int RoleId { get; set; }

        [Column("rolename")]
        [StringLength(100)]
        public string RoleName { get; set; } = string.Empty;

        [Column("description")]
        public string? Description { get; set; }
    }
}
