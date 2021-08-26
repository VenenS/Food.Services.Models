using System.Runtime.Serialization;

namespace ITWebNet.Food.Core.DataContracts.Common
{
    /// <summary>
    /// Типы объектов для привязки к тегам
    /// </summary>
    [DataContract(Name = "TypesForLinkToTags")]
    public enum ObjectTypesEnum
    {
        /// <summary>
        /// Тип объекта - кафе
        /// </summary>
        [EnumMember]
        CAFE = 1,
        /// <summary>
        /// Тип объекта - блюдо
        /// </summary>
        [EnumMember]
        CATEGORY = 2,
        /// <summary>
        /// Тип объекта - Категория
        /// </summary>
        [EnumMember]
        DISH = 3,
        /// <summary>
        /// Тип объекта - что-то непонятное
        /// </summary>
        [EnumMember]
        ANOTHER_TYPE = 0,
    }
}
