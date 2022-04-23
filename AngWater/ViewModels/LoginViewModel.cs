using System.ComponentModel.DataAnnotations;

namespace AngWater.ViewModels
{
    public class LoginViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email Address")]
        public string EmailAddress { get; set; }

        [Required]
        [Display(Name = "Name")]
        public string Name { get; set; }
    }
}
