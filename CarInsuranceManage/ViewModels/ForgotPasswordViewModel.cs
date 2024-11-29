using System.ComponentModel.DataAnnotations;

namespace CarInsuranceManage.ViewModels
{
    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
