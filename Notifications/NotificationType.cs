using System.ComponentModel;
using System.Runtime.Serialization;

namespace ITWebNet.Food.Core.DataContracts.Common
{
    /// <summary>
    /// Типы уведомлений
    /// </summary>
    [DataContract(Name = "NotificationType")]
    public enum NotificationType
    {
        /// <summary>
        /// Unknown
        /// </summary>
        [Description("Unknown")]
        [EnumMember]
        Default = 0,
        /// <summary>
        /// Регистрация нового пользователя
        /// </summary>
        [Description("Регистрация нового пользователя")]
        [EnumMember]
        UserRegistration = 1,
        /// <summary>
        /// Создание нового заказа
        /// </summary>
        [Description("Создание нового заказа")]
        [EnumMember]
        OrderCreate = 2,
        /// <summary>
        /// Отмена заказа
        /// </summary>
        [Description("Отмена заказа")]
        [EnumMember]
        OrderAbort = 3,
        /// <summary>
        /// Отзыв пользователя с сайта
        /// </summary>
        [Description("Отмена заказа")]
        [EnumMember]
        UserReply = 4
    }
}
