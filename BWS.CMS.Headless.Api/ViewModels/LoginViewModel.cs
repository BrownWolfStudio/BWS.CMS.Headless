using System.ComponentModel.DataAnnotations;

namespace BWS.CMS.Headless.Api.ViewModels
{
    public class LoginViewModel
    {
        [Required]
        public string UserName { get; set; }

        [Required]
        public string Password { get; set; }
    }
}