using System.ComponentModel.DataAnnotations;

namespace ITWebNet.Food.Core.DataContracts.Account
{
    public class ForgotPasswordModel
    {
        [Required(ErrorMessage = "Обязательное поле")]
        [Display(Name = "Email")]
        [StringLength(70, ErrorMessage = "Максимальное количество символов для электронного адреса - {1}")]
        public string Email { get; set; }

        [Required]
        public string ReturnUrl { get; set; }

    }
}
