using System.ComponentModel.DataAnnotations;

namespace WatchStore.Web.Areas.Identity.Models.Account
{
    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
