using System.ComponentModel;
using System.Runtime.Serialization;

namespace Food.Services.Contracts
{
    /// <summary>
    /// Типы организаций
    /// </summary>
    [DataContract(Name = "OrganizationType")]
    public enum OrganizationTypeEnum
    {
        /// <summary>
        /// Unknown
        /// </summary>
        [Description("Unknown")]
        [EnumMember]
        Default = 0,
        /// <summary>
        /// Тип объекта кафе
        /// </summary>
        [Description("Тип объекта кафе")]
        [EnumMember]
        Cafe = 1,
        /// <summary>
        /// Тип объекта компания
        /// </summary>
        [Description("Тип объекта компания")]
        [EnumMember]
        Company = 2
    }
}
