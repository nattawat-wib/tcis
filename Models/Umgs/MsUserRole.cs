using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace tcirs_service.Models.Umgs
{
    [Table("msuserrole", Schema = "ugms")]
    public class MsUserRole
    {
        [Key, Column("userid", Order = 0)]
        public int UserId { get; set; }

        [Key, Column("roleid", Order = 1)]
        public int RoleId { get; set; }
    }
}
