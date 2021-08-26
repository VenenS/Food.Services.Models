using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace ITWebNet.Food.Core.DataContracts.Common
{
    ///// <summary>
    ///// Типы оплаты заказа
    ///// </summary>
    //[DataContract(Name = "PaymentType")]
    //public enum PaymentTypeEnum
    //{
    //    [Description("По умолчанию")]
    //    [EnumMember]
    //    Default = 0,

    //    /// <summary>
    //    /// Оплата услуг онлайн
    //    /// </summary>
    //    [Description("Онлайн оплата")]
    //    [EnumMember]
    //    Online = 1,

    //    /// <summary>
    //    /// Оплата услуг доставщику
    //    /// </summary>
    //    [Description("Оплата доставщику")]
    //    [EnumMember]
    //    Delivery = 2,

    //    /// <summary>
    //    /// Оплата доставщику при помощи терминала
    //    /// </summary>
    //    [Description("Оплата доставщику при помощи терминала")]
    //    [EnumMember]
    //    DeliveryByTerminal = 3,

    //    /// <summary>
    //    /// Оплата через компанию
    //    /// </summary>
    //    [Description("Оплата через компанию")]
    //    [EnumMember]
    //    Company = 4,

    //    /// <summary>
    //    /// Оплачено баллами
    //    /// </summary>
    //    [Description("Оплачено баллами")]
    //    [EnumMember]
    //    PaidPoints = 5
    //}


    [Flags]
    public enum PaymentTypeEnum : short
    {
        None = 0,

        [Description("По умолчанию")]
        Default = CashOnly,

        /// <summary>
        /// Наличными (1)
        /// </summary>
        [Description("Наличными")]
        CashOnly = 0x0001,

        /// <summary>
        /// Картой на сайте (2)
        /// </summary>
        [Description("Картой на сайте")]
        OnlineOnly = 0x0010,

        ///// <summary>
        ///// Наличными/Картой на сайте (3)
        ///// </summary>
        //[Description("Наличными/Картой на сайте")]
        //CashAndOnline = CashOnly | OnlineOnly,

        /// <summary>
        /// Картой курьеру (4)
        /// </summary>
        [Description("Картой курьеру")]
        ByCardToTheCourierOnly = 0x0100,

        ///// <summary>
        ///// Наличными/Картой курьеру (5)
        ///// </summary>
        //[Description("Наличными/Картой курьеру")]
        //CourierOnly = CashOnly | ByCardToTheCourierOnly,

        ///// <summary>
        ///// Картой на сайте/Картой курьеру (6)
        ///// </summary>
        //[Description("Картой на сайте/Картой курьеру")]
        //CardOnly = OnlineOnly | ByCardToTheCourierOnly,

        ///// <summary>
        ///// Наличными/Картой курьеру/Картой на сайте (7)
        ///// </summary>
        //[Description("Наличными/Картой курьеру/Картой на сайте")]
        //All = CashOnly | ByCardToTheCourierOnly | OnlineOnly,
    }
}
