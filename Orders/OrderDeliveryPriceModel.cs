using System;

namespace ITWebNet.Food.Core.DataContracts.Common
{
    /// <summary>
    /// Класс для описания стоимости доставки. Нужен в основном для корпоративных заказов, для которых надо показывать:
    /// * общую стоимость доставки;
    /// * количество заказов, на которые делится общая стоимость;
    /// * стоимость, которую должен платить клиент (стоимость доставки для одного заказа - результат деления).
    /// </summary>
    public class OrderDeliveryPriceModel
    {
        /// <summary>
        /// Флаг корпоративного заказа
        /// </summary>
        public bool CompanyOrder { get; set; } = false;
        /// <summary>
        /// Общая стоимость доставки - её нужно будет делить на всех
        /// </summary>
        public double TotalPrice { get; set; } = 0.0;
        /// <summary>
        /// Количество заказов от данной компании в выбранном кафе на данный момент
        /// </summary>
        public int CountOfOrders { get; set; } = 1;
        /// <summary>
        /// Цена доставки каждого заказа - результат деления общей стоимости доставки на количество заказов
        /// </summary>
        public double PriceForOneOrder { get; set; } = 0.0;
        /// <summary>
        /// Описание ошибки при вычислении стоимости доставки. Если ошибки не было - пустая строка.
        /// </summary>
        public string ErrorDescription { get; set; } = string.Empty;
    }

    public class CompanyOrderShippingCostsModel
    {
        /// <summary>
        /// Общая стоимость доставки - её нужно будет делить на всех
        /// </summary>
        public double ShippingCost { get; set; }

        /// <summary>
        /// Количество заказов от данной компании в выбранном кафе на данный момент
        /// </summary>
        public int OrderCount { get; set; }
    }
}
