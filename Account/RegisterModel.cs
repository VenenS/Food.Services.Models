using System.ComponentModel.DataAnnotations;

namespace ITWebNet.Food.Core.DataContracts.Account
{
    public class RegisterModel
    {
        /// <summary>
        /// Телефон пользователя
        /// </summary>
        [Required(ErrorMessage = "Некорректно введен номер телефона")]
        [RegularExpression(@"^(\+7[\ ]?)?\(9?\d{2}\)[\ ]?\d{3}[\ ]?\d{4}", ErrorMessage = "Код оператора должен начинаться с 9 и содержать 10 цифр")]
        public string PhoneNumber { get; set; }

        
        [Required(ErrorMessage = "Некорректный Email")]
        [RegularExpression(@"^([a-zA-Z0-9_\.-]+)@([A-Za-z0-9_\.-]+)\.([A-Za-z\.]{2,6})$", 
            ErrorMessage = "Некорректный Email")]
        [Display(Name = "Email")]
        [StringLength(70, ErrorMessage = "Максимальное количество символов для электронного адреса - {1}")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Обязательное поле")]
        [DataType(DataType.Password)]
        [StringLength(50, MinimumLength = 6, ErrorMessage = "{0} должен быть не менее {2} и не более {1} символов")]
        [Display(Name = "Пароль")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Обязательное поле")]
        [DataType(DataType.Password)]
        [StringLength(50, MinimumLength = 6, ErrorMessage = "{0} должен быть не менее {2} и не более {1} символов")]
        [Compare("Password", ErrorMessage = "Введенные пароли не совпадают")]
        [Display(Name = "Подтвердите пароль")]
        public string ConfirmPassword { get; set; }

        public string ReferralLink { get; set; }

        public string ReturnUrl { get; set; }
    }
}
