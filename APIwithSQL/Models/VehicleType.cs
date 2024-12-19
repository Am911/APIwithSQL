using System.ComponentModel.DataAnnotations;

namespace APIwithSQL.Models
{
    public class VehicleType
    {
        [Key]
        public int VehicleType_ID { get; set; }
        public string VehicleTypeName { get; set; }
        public string Remark { get; set; }
        public bool VehicleEnabled { get; set; }
        public DateTime CretaedOn { get; set; }
    }
}
