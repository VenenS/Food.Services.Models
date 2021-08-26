using System.ComponentModel;
using System.Runtime.Serialization;

namespace ITWebNet.Food.Core.DataContracts.Common
{
    /// <summary>
    /// Типы действий для <see cref="PushMessageModel"/>
    /// </summary>
    [DataContract(Name = "Action")]
    public enum ActionEnum
    {
        /// <summary>
        /// Информационное сообщение
        /// </summary>
        [Description("Сообщение")]
        [EnumMember]
        Info = 0,

        /// <summary>
        /// Сообщение об успешной операции
        /// </summary>
        [Description("Успех!")]
        [EnumMember]
        Success = 1,

        /// <summary>
        /// Предупреждающее сообщение
        /// </summary>
        [Description("Внимание!")]
        [EnumMember]
        Warning = 2,

        /// <summary>
        /// Очень важное (критическое) сообщение
        /// </summary>
        [Description("Критическое предупреждение!")]
        [EnumMember]
        Danger = 3,

        /// <summary>
        /// Принудельный выход пользователя со всех активных устройств
        /// </summary>
        [Description("Принудительный выход")]
        [EnumMember]
        Logout = 4
    }
}
