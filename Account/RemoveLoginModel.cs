using System.ComponentModel.DataAnnotations;

namespace ITWebNet.Food.Core.DataContracts.Account
{
    public class RemoveLoginModel
    {
        [Required]
        [Display(Name = "Провайдер")]
        public string LoginProvider { get; set; }

        [Required]
        [Display(Name = "Ключ провайдера")]
        public string ProviderKey { get; set; }
    }
}
