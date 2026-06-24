using System.ComponentModel.DataAnnotations;

namespace EShop.Data.DTOs.Account
{
    public class RegisterUserDTO
    {
        [Display(Name = "شماره موبایل")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(12, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد")]
        [MinLength(12, ErrorMessage = "{0} نمی تواند کمتر از {1} کاراکتر باشد")]
        public string MobileNumber { get; set; }
    }
}
