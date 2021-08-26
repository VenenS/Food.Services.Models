using System.ComponentModel.DataAnnotations;

namespace ITWebNet.Food.Core.DataContracts.Account
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Введите email")]
        [Display(Name = "Email")]
        [StringLength(70, ErrorMessage = "Максимальное количество символов для электронного адреса - {1}")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Введите пароль")]
        [DataType(DataType.Password)]
        [Display(Name = "Пароль")]
        public string Password { get; set; }

        [Display(Name = "Запомнить меня")]
        public bool RememberMe { get; set; }
    }
}
