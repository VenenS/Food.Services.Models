using System.ComponentModel.DataAnnotations;

namespace ITWebNet.Food.Core.DataContracts.Common
{
    public enum DisplayAddressType
    {
        /// <summary>
        /// Покатывать полный адрес конкатенацией строк
        /// </summary>
        [Display(Name = "Полный адрес")]
        Full = 0,
        /// <summary>
        /// Показывать адрес из поля RawAddress
        /// </summary>
        [Display(Name = "Отображаемый адрес")]
        Display = 1
    }
}