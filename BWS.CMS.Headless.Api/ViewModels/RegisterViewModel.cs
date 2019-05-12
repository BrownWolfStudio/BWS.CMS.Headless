using System.ComponentModel.DataAnnotations;

namespace BWS.CMS.Headless.Api.ViewModels
{
    public class RegisterViewModel
    {
        [Required, MaxLength(15)]
        public string UserName { get; set; }

        [Required, EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }
    }
}