using ITWebNet.Food.Core.DataContracts.Manager;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ITWebNet.Food.Core.DataContracts.Common
{
    public class BanketModel
    {
        public long Id { get; set; }

        public long CafeId { get; set; }

        [Required(ErrorMessage = "Обязательное поле")]
        [Display(Name = "Компания")]
        public long CompanyId { get; set; }

        [Required(ErrorMessage = "Обязательное поле")]
        [Display(Name = "Меню")]
        public long MenuId { get; set; }

        [Required(ErrorMessage = "Обязательное поле")]
        [Display(Name = "Дата банкета")]
        public DateTime EventDate { get; set; }

        [Required(ErrorMessage = "Обязательное поле")]
        [Display(Name = "Дата начала заказа")]
        public DateTime OrderStartDate { get; set; }

        [Required(ErrorMessage = "Обязательное поле")]
        [Display(Name = "Дата окончания заказа")]
        public DateTime OrderEndDate { get; set; }

        //[Required(ErrorMessage = "Обязательное поле")]
        [Display(Name = "Название банкета")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Обязательное поле")]
        [Display(Name = "Статус заказа")]
        public BanketStatus Status { get; set; }

        //[Required(ErrorMessage = "Обязательное поле")]
        [Display(Name = "Уникальная последовательность символов")]
        public string Url { get; set; }

        public double TotalSum { get; set; }

        public CompanyModel Company { get; set; }
        public CafeModel Cafe { get; set; }
        public CafeMenuPatternModel Menu { get; set; }
        public List<OrderModel> Orders { get; set; }
    }
}