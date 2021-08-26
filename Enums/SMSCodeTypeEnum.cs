using System.ComponentModel;
using System.Runtime.Serialization;

namespace Food.Services.Models
{
    public enum SMSCodeTypeEnum
    {
        /// <summary>
        /// Только цифры
        /// </summary>
        [Description("Только цифры")]
        Numeric = 0,

        /// <summary>
        /// Только буквы
        /// </summary>
        [Description("Только буквы")]
        Alphabet = 1,

        /// <summary>
        /// Только цифры
        /// </summary>
        [Description("Цифры и буквы")]
        Mixed = 2,
    }
}
