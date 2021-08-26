using System;
using System.ComponentModel.DataAnnotations;

namespace ITWebNet.Food.Core.DataContracts.Common
{

    public class FoodCategoryModel
    {
        public Int64 Id { get; set; }
        
        [Required(ErrorMessage = "Введите название категории")]
        [Display(Name = "Название")]
        [StringLength(50, ErrorMessage = "Максимальная длина - {1}")]
        public string Name { get; set; }
        
        [Display(Name = "Полное название")]
        [StringLength(100, ErrorMessage = "Максимальная длина - {1}")]
        public string FullName { get; set; }
        
        [StringLength(1024, ErrorMessage = "Максимальная длина - {1}")]
        [Display(Name = "Описание")]
        public string Description { get; set; }
        
        public int? Index { get; set; }

        public Guid Uuid { get; set; }
    }
}
