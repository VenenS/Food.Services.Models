using System.Runtime.Serialization;

namespace ITWebNet.Food.Core.DataContracts.Common
{
    /// <summary>
    /// Типы статусов заказа компании
    /// Хардкод значений из таблицы order_status.id
    /// </summary>
    [DataContract(Name = "CompanyOrderStatusTypes")]
    public enum CompanyOrderStatusEnum1
    {
        /// <summary>
        /// Корпоративный заказ создан
        /// </summary>
        [EnumMember]
        Created = 23,

        /// <summary>
        /// Размещение заказов в корпоративном заказе
        /// </summary>
        [EnumMember]
        Ordering = 24,

        /// <summary>
        /// Размещение заказов в корпоративном заказе завершено
        /// </summary>
        [EnumMember]
        OrderingCompleted = 25,

        /// <summary>
        /// Корпоративный заказ отменен на стадии размещения заказов
        /// </summary>
        [EnumMember]
        OrderingAborted = 26,

        /// <summary>
        /// Приготовление корпоративного заказа
        /// </summary>
        [EnumMember]
        Cooking = 27,

        /// <summary>
        /// Приготовление корпоративного заказа завершено
        /// </summary>
        [EnumMember]
        Cooked = 28,

        /// <summary>
        /// Корпоративный заказ отменен на стадии приготовления
        /// </summary>
        [EnumMember]
        CookingAborted = 29,

        /// <summary>
        /// Доставка корпоративного заказа
        /// </summary>
        [EnumMember]
        Delivering = 30,

        /// <summary>
        /// Доставка корпоративного заказа завершена
        /// </summary>
        [EnumMember]
        Delivered = 31,

        /// <summary>
        /// Корпоративный заказ выполнен
        /// </summary>
        [EnumMember]
        Completed = 32,

        /// <summary>
        /// Unknown
        /// </summary>
        [EnumMember]
        Default = 0
    }
}
