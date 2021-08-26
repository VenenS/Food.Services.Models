using ITWebNet.Food.Core.DataContracts.Admin;
using System;
using System.Collections.Generic;

namespace ITWebNet.Food.Core.DataContracts.Common
{
    public class PageDishInMenuHistoryModel
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public double? Weight { get; set; }

        public string Description { get; set; }
        public string CategoryName { get; set; }
        public List<DishInMenuHistoryModel> DishesHistory { get; set; }

        /// <summary>
        /// Ключ - Id категории.
        /// Значение - имя категории
        /// </summary>
        public Dictionary<long, string> DishCategoryIdNames { get; set; }
    }
}
