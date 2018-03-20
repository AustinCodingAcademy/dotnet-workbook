using System.ComponentModel.DataAnnotations;

namespace Cozy.WebUI.ViewModel
{
    public class RegisterViewModel
    {
        [Required, EmailAddress]
        public string Email { get; set; }

        [Required, DataType(DataType.Password)]
        public string Password { get; set; }

        [Required, DataType(DataType.Password), Compare("Password", ErrorMessage = "Both Passwords need to match")]
        [Display(Name = "Confirm Password")]
        public string ConfirmedPassword { get; set; }
    }
}
