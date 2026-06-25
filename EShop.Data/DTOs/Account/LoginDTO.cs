using System.ComponentModel.DataAnnotations;

namespace EShop.Data.DTOs.Account
{
    public class LoginDTO
    {
        [Display(Name = "شماره موبایل")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(11, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد")]
        public string MobileNumber { get; set; }
        public string? ReturnUrl { get; set; }
    }
}
