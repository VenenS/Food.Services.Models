using System.ComponentModel;
using System.Runtime.Serialization;

namespace ITWebNet.Food.Core.DataContracts.Common
{
    /// <summary>
    /// Типы каналов уведомлений
    /// </summary>
    [DataContract(Name = "NotificationChannel")]
    public enum NotificationChannelModel
    {
        /// <summary>
        /// Unknown
        /// </summary>
        [Description("Unknown")]
        [EnumMember]
        Default = 0,
        /// <summary>
        /// Email
        /// </summary>
        [Description("Email")]
        [EnumMember]
        Email = 1,
        /// <summary>
        /// SMS
        /// </summary>
        [Description("SMS")]
        [EnumMember]
        SMS = 2,
        /// <summary>
        /// Автоматический звонок
        /// </summary>
        [Description("Автоматический звонок")]
        [EnumMember]
        PhoneAuto = 3,
        /// <summary>
        /// Звонок от оператора
        /// </summary>
        [Description("Звонок от оператора")]
        [EnumMember]
        PhoneOperator = 4
    }
}
