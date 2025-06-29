using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace tcirs_service.Models.Master
{
    [Table("mscity", Schema = "master")]
    public class MsCity
    {
        [Key]
        public int ID { get; set; }

        [StringLength(3)]
        public string CityCode { get; set; } = string.Empty;

        [StringLength(50)]
        public string CityName { get; set; } = string.Empty;

        [StringLength(1)]
        public string Status { get; set; } = string.Empty;

        public int IsDelete { get; set; }
    }
}
