using System.ComponentModel.DataAnnotations;

namespace AngWater.Models
{
    public class Log: BaseModel
    {
        [Required]
        public string EmailAddress { get; set; }

        [Required]
        public string Name { get; set; }

        public DateTime LoggedDate { get; set; }
    }
}
