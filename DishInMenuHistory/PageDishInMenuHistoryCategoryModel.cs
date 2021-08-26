using ITWebNet.Food.Core.DataContracts.Admin;
using System;
using System.Collections.Generic;

namespace ITWebNet.Food.Core.DataContracts.Common
{
    public class PageDishInMenuHistoryCategoryModel
    {
        public string CategoryName { get; set; }

        public List<PageDishInMenuHistoryModel> PageDisthes { get; set; }
    }
}
