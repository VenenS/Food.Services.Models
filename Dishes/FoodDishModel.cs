using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace ITWebNet.Food.Core.DataContracts.Common
{
    public class FoodDishModel
    {
        public Int64 Id { get; set; }
        
        [Display(Name = "Название")]
        public string Name { get; set; }
        
        [Display(Name = "Калорийность")]
        public double? Kcalories { get; set; }
        
        [Display(Name = "Вес")]
        public double? Weight { get; set; }
        
        [Display(Name = "Описание веса")]
        public string WeightDescription { get; set; }
        
        [Display(Name = "Цена")]
        [Range(1, 999999, ErrorMessage ="Цена не может быть отрицательным числом, либо нулем, либо больше {2}")]
        [RegularExpression(@"[0-9]*,?[0-9]{0,2}", ErrorMessage = "Цена указана некорректно")]
        public double BasePrice { get; set; }
        
        [Display(Name = "Описание"), DataType(DataType.MultilineText)]
        public string Description { get; set; }
        
        [Display(Name = "Состав")]
        public string Composition { get; set; }
        
        public int? DishIndex { get; set; }
        
        [Display(Name = "Начало")]
        [DataType(DataType.Date)]
        public DateTime? VersionFrom { get; set; }
        
        [Display(Name = "Окончание")]
        [DataType(DataType.Date)]
        public DateTime? VersionTo { get; set; }
        
        public Guid Uuid { get; set; }
        
        public Int64 CategoryId { get; set; }

        public List<SelectableFoodCategoryModel> FoodCategories { get; set; }

        /// <summary>
        /// Ключ - идентификатор категории.
        /// Значение - индекс в категории
        /// </summary>
        [XmlIgnore]
        public Dictionary<long, int?> DishIndexToCategory { get; set; }
        
        public Int64 DishRatingSumm { get; set; }
        
        public Int64 DishRatingCount { get; set; }
        
        public string Image { get; set; }
        
        public List<ScheduleModel> Schedules { get; set; }

        /// <summary>
        /// Идентификатор кафе
        /// </summary>
        public long CafeId { get; set; }
        /// <summary>
        /// Название кафе
        /// </summary>
        public string CafeName { get; set; }
        /// <summary>
        /// URL кафе для создания ссылки
        /// </summary>
        public string CafeUrl { get; set; }
        /// <summary>
        /// Логотип кафе (если есть)
        /// </summary>
        public string CafeLogo { get; set; }
        /// <summary>
        /// Время начала работы кафе
        /// </summary>
        public DateTime? CafeTimeFrom { get; set; }
        /// <summary>
        /// Время окончания работы кафе
        /// </summary>
        public DateTime? CafeTimeTo { get; set; }
        /// <summary>
        /// Процент скидки для пользователя
        /// </summary>
        public int Discount { get; set; }
    }
}
