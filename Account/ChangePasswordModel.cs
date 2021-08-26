using System.ComponentModel.DataAnnotations;

namespace ITWebNet.Food.Core.DataContracts.Account
{
    public class ChangePasswordModel
    {
        [Required(ErrorMessage = "Требуется заполнить поле")]
        [StringLength(50, MinimumLength = 6, ErrorMessage = "{0} должен быть не менее {2} и не более {1} символов")]
        [DataType(DataType.Password)]
        [Display(Name = "Текущий пароль")]
        public string OldPassword { get; set; }

        [Required(ErrorMessage = "Требуется заполнить поле")]
        [StringLength(50, MinimumLength = 6, ErrorMessage = "{0} должен быть не менее {2} и не более {1} символов")]
        [DataType(DataType.Password)]
        [Display(Name = "Новый пароль")]
        public string NewPassword { get; set; }

        [DataType(DataType.Password)]
        [StringLength(50, MinimumLength = 6, ErrorMessage = "{0} должен быть не менее {2} и не более {1} символов")]
        [Display(Name = "Новый пароль (еще раз)")]
        [Compare("NewPassword", ErrorMessage = "Введенные пароли не совпадают")]
        public string ConfirmPassword { get; set; }
    }
}
