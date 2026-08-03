using System.ComponentModel.DataAnnotations;

namespace KingdomCommunityWebline.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Email Address is required")]
        [EmailAddress]
        public string EmailAddress {  get; set; } = string.Empty;
    }
}
