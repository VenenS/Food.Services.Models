using System;

namespace ITWebNet.Food.Core.DataContracts.Common
{
    public class FoodDishVersionModel
    {
        public Int64 Id { get; set; }
        
        public Int64 DishId { get; set; }
        
        public string Name { get; set; }
        
        public double? Kcalories { get; set; }
        
        public double? Weight { get; set; }
        
        public string WeightDescription { get; set; }
        
        public double BasePrice { get; set; }
        
        public DateTime? VersionFrom { get; set; }
        
        public DateTime? VersionTo { get; set; }
    }
}
