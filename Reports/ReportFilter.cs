using System;
using System.Collections.Generic;

namespace ITWebNet.Food.Core.DataContracts.Common
{
    public class ReportFilter
    {
        public List<OrderStatusEnum> AvailableStatusList { get; set; }

        public long? CompanyId { get; set; }

        public long? CafeId { get; set; }

        public List<Int64> CompanyOrdersIdList { get; set; }

        public List<Int64> BanketOrdersIdList { get; set; }

        public DateTime StartDate { get; set; }

        public SearchType SearchType { get; set; }

        public string Search { get; set; }

        public DateTime EndDate { get; set; }

        public bool LoadUserOrders { get; set; }

        public bool LoadOrderItems { get; set; }

        public List<Int64> OrdersIdList { get; set; }

        public Int64 ReportTypeId { get; set; }

        public ReportExtension ReportExtension { get; set; }

        public long? UserId { get; set; }

        /// <summary>
        /// Тип сортировки
        /// </summary>
        public ReportSortType SortType { get; set; }

        /// <summary>
        /// Метод упорядочивания результатов сортировки (по возрастанию/по убыванию).
        /// </summary>
        public ReportResultOrder ResultOrder { get; set; }
    }
}
