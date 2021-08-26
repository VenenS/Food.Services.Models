using ITWebNet.Food.Core.DataContracts.Common;
using System.Collections.Generic;

namespace Food.Services.Models
{
    /// <summary>
    /// Используется для смены статусов заказов, вложенных в корп. заказ
    /// </summary>
    public class OrdersChangeStatusModel
    {
        /// <summary>
        /// Идентификаторы заказов, у которых необходимо обновить статус
        /// </summary>
        public List<long> OrderIds { get; set; }

        /// <summary>
        /// Статус
        /// </summary>
        public OrderStatusEnum Status { get; set; }
    }
}
