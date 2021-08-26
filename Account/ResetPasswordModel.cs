using System.ComponentModel.DataAnnotations;

namespace ITWebNet.Food.Core.DataContracts.Account
{
    public class ResetPasswordModel
    {
        //[Required]
        [RegularExpression(@"^([a-zA-Z0-9_\.-]+)@([A-Za-z0-9_\.-]+)\.([A-Za-z\.]{2,6})$", 
            ErrorMessage = "Некорректный Email")]
        [Display(Name = "Email")]
        [StringLength(70, ErrorMessage = "Максимальное количество символов для электронного адреса - {1}")]
        public string Email { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 6, ErrorMessage = "{0} должен быть не менее {2} символов")]
        [DataType(DataType.Password)]
        [Display(Name = "Пароль")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Пароль (еще раз)")]
        [Compare("Password", ErrorMessage = "Введенные пароли не совпадаю")]
        public string ConfirmPassword { get; set; }

        public string Code { get; set; }
    }
}
