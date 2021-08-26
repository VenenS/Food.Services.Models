using System;
using System.Collections.Generic;

namespace ITWebNet.Food.Core.DataContracts.Common
{
    public class BanketsFilterModel
    {
        public List<long> BanketIds { get; set; }
        public bool LoadOrders { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public long? CafeId { get; set; }

        /// <summary>
        /// Тип поиска
        /// </summary>
        public SearchType SearchType { get; set; }
        /// <summary>
        /// Строка поиска
        /// </summary>
        public string Search { get; set; }
        /// <summary>
        /// Тип сортировки
        /// </summary>
        public ReportSortType SortType { get; set; }
    }
}