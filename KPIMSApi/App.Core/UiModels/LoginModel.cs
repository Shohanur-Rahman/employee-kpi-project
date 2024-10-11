using System.ComponentModel.DataAnnotations;

namespace KPIMS.Core.UiModels
{
    public class LoginModel
    {
        [Required(ErrorMessage ="Enter your email address")]
        public string Email { get; set; } = string.Empty;
        [Required(ErrorMessage = "Enter your last password")]
        public string Password { get; set; } = string.Empty;
        public bool IsRemember { get; set; }
    }
}
