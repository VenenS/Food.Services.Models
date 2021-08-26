using System.Collections.Generic;

namespace ITWebNet.Food.Core.DataContracts.Common
{
    public class FoodCategoryWithDishes
    {
        public FoodCategoryModel Category { get; set; }
        /// <summary>
        /// Общее количество доступных блюд. Нужно для главной страницы, на которой должно отображаться 6 случайных блюд из каждой категории и кнопка "показать ещё +N"
        /// </summary>
        public int CountOfDishes { get; set; } = 0;
        public List<FoodDishModel> Dishes { get; set; }
    }
}
