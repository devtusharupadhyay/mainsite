using System.ComponentModel.DataAnnotations;

namespace AngWater.Models
{
    public class Schedule : BaseModel
    {
        [Required]
        public string Speaker { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        public short Channel { get; set; }
    }
}
