using System.ComponentModel.DataAnnotations;

namespace ITWebNet.Food.Core.DataContracts.Common
{
    public enum CafeType
    {
        [Display(Name = "Только физ. лица")]
        PersonOnly = 0,
        [Display(Name = "Только компании")]
        CompanyOnly = 1,
        [Display(Name = "Все пользователи")]
        CompanyPerson = 2
    }
}