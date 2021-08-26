using System;
using System.Collections.Generic;

namespace Food.Services.Models
{
    /// <summary>
    /// Запрос из корзины для определения принадлежности заказа
    /// </summary>
    public class RequestCartCompanyOrderModel
    {
        /// <summary>
        /// Идентификаторы кафе, в которых был сделан заказ
        /// </summary>
        public HashSet<long> CafeIds { get; set; }

        /// <summary>
        /// Дата заказа
        /// </summary>
        public HashSet<DateTime> Dates { get; set; }

        /// <summary>
        /// Идентификатор компании, в которую делается заказ
        /// </summary>
        public long CompanyId { get; set; }
    }
}
