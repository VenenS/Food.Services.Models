using ITWebNet.Food.Core.DataContracts.Admin;
using System.ComponentModel.DataAnnotations;

namespace ITWebNet.Food.Core.DataContracts.Common
{
    public class CompanyCuratorModel
    {
        public long Id { get; set; }
        public long CompanyId { get; set; }

        [Required]
        [Display(Name = "Пользователь")]
        public long UserId { get; set; }

        public UserAdminModel User { get; set; }
    }
}