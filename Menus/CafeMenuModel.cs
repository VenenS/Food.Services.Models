using System.Collections.Generic;
using ITWebNet.Food.Core.DataContracts.Common;

namespace ITWebNet.Food.Core.DataContracts.Manager
{
    public class CafeMenuModel
    {
        public FoodCategoryModel Category { get; set; }
        public List<FoodDishModel> Dishes { get; set; }
    }
}