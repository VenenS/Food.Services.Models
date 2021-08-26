using System.ComponentModel.DataAnnotations;

namespace ITWebNet.Food.Core.DataContracts.Account
{
    public class SetPasswordModel
    {
        [Required]
        [StringLength(50, MinimumLength = 6, ErrorMessage = "{0} должен быть не менее {2} и не более {1} символов")]
        [DataType(DataType.Password)]
        [Display(Name = "Новый пароль")]
        public string NewPassword { get; set; }

        [DataType(DataType.Password)]
        [Compare("NewPassword", ErrorMessage = "Введенные пароли не совпадают")]
        [Display(Name = "Подтвердите новый пароль")]
        public string ConfirmPassword { get; set; }

    }
}
