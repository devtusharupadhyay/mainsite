using System.ComponentModel.DataAnnotations;

namespace AngWater.Models
{
    public class User : BaseModel
    {
        
        [Required]
        public string EmailAddress { get; set; }

    }
}
