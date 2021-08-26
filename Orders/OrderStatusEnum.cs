using System.ComponentModel;
using System.Runtime.Serialization;

namespace ITWebNet.Food.Core.DataContracts.Common
{
    /// <summary>
    /// Типы статусов заказа пользователя
    /// </summary>
    [DataContract(Name = "OrderStatusTypes")]
    public enum OrderStatusEnum
    {
        /// <summary>
        /// Заказ создан
        /// </summary>
        [Description("Новый заказ")]
        [EnumMember]
        Created = 1,
        /// <summary>
        /// Заказ принят
        /// </summary>
        [Description("Заказ принят кафе")]
        [EnumMember]
        Accepted = 2,
        /// <summary>
        /// Заказ в процессе доставки
        /// </summary>
        [Description("Заказ в процессе доставки")]
        [EnumMember]
        Delivery = 3,
        /// <summary>
        /// Заказ доставлен. Итоговая стадия заказа
        /// </summary>
        [Description("Заказ успешно доставлен")]
        [EnumMember]
        Delivered = 4,
        /// <summary>
        /// Заказ отменен
        /// </summary>
        [Description("Заказ отменён")]
        [EnumMember]
        Abort = 5,
        /// <summary>
        /// Корзина с сайта
        /// </summary>
        [Description("Unknown")]
        [EnumMember]
        Cart = 6
    }
}
