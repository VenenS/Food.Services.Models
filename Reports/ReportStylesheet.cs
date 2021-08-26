using System;
using System.ComponentModel.DataAnnotations;

namespace ITWebNet.Food.Core.DataContracts.Manager
{
    public class XSLTModel
    {
        public Int64 Id { get; set; }

        [Required(ErrorMessage = "Обязательное поле")]
        [Display(Name = "Название")]
        public string Name { get; set; }

        [Display(Name = "Описание")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Обязательное поле")]
        [Display(Name = "Шаблон")]
        public string Transformation { get; set; }

        public Int64? CafeId { get; set; }

        public Int64 ExtId { get; set; }

        [Display(Name = "Тип шаблона")]
        public bool IsCommon { get; set; }
    }
}
