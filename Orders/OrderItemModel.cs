using System;

namespace ITWebNet.Food.Core.DataContracts.Common
{
    public class OrderItemModel
    {
        public Int64 Id { get; set; }
        
        public Int64 FoodDishId { get; set; }
        
        public int DishCount { get; set; }
        
        public int? Discount { get; set; }
        
        public string Comment { get; set; }
        
        public bool IsDeleted { get; set; }
        
        public string DishName { get; set; }
        
        public double? DishKcalories { get; set; }
        
        public double? DishWeight { get; set; }
        
        public double TotalPrice { get; set; }
        
        public double DishBasePrice { get; set; }
    }
}
