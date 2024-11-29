using System.ComponentModel.DataAnnotations;

namespace CarInsuranceManage.ViewModels
{
    public class RegisterViewModel
    {
        [Display (Name ="Email")]
        [Required(ErrorMessage = "Please enter email.")]
        [EmailAddress(ErrorMessage = "Invalid email.")]
        public string email { get; set; }

        [Display (Name = "Password")]
        [Required(ErrorMessage = "Please enter your password.")]
        [DataType(DataType.Password)]
        [StringLength(255)]
        public string password { get; set; }

        [Display (Name ="Confirm Password")]
        [Required(ErrorMessage = "Please re-enter your password.")]
        [DataType(DataType.Password)]
        [Compare("password", ErrorMessage = "Passwords do not match.")]
        public string ConfirmPassword { get; set; }
    }
}
