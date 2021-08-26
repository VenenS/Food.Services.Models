using ITWebNet.Food.Core.DataContracts.Manager;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ITWebNet.Food.Core.DataContracts.Common
{

    public class CafeModel
    {
        public Int64 Id { get; set; }

        [Display(Name = "Название")]
        [StringLength(50, ErrorMessage = "Количество символов должно быть не больше {1}")]
        [Required(ErrorMessage = "Введите название кафе")]
        public string Name { get; set; }

        [Display(Name = "Полное Название")]
        [StringLength(250, ErrorMessage = "Количество символов должно быть не больше {1}")]
        [Required(ErrorMessage = "Введите полное название кафе")]
        public string FullName { get; set; }

        public string Description { get; set; }

        public string ShortDescription { get; set; }

        [Display(Name = "Тип кафе")]
        public CafeType CafeType { get; set; }

        public Guid Uuid { get; set; }

        public Int64 CafeRatingSumm { get; set; }

        public Int64 CafeRatingCount { get; set; }

        [Display(Name = "URL название")]
        [RegularExpression("^([a-zA-Z0-9 '-]+)$", ErrorMessage = "Неверный URL")]
        [StringLength(50, ErrorMessage = "Количество символов должно быть не больше {1}")]
        [Required(ErrorMessage = "Введите URL название кафе")]
        public string CleanUrlName { get; set; }

        public double? MinimumSumRub { get; set; }

        public int? AverageDeliveryTime { get; set; }

        public double? DeliveryPriceRub { get; set; }

        public List<List<CafeBusinessHoursItemModel>> WorkingHours { get; set; }

        public DateTime? WorkingTimeFrom { get; set; }

        public DateTime? WorkingTimeTo { get; set; }

        public bool IsRest { get; set; }

        public bool? OnlinePaymentSign { get; set; }

        public Int64? CafeSpecializationId { get; set; }

        public List<CostOfDeliveryModel> CostOfDelivery { get; set; }

        public bool AllowPaymentByPoints { get; set; }

        public string SmallImage { get; set; }

        public string BigImage { get; set; }

        /// <summary>
        /// Иконка - маленькая картинка макс.48x48 (реально выводится 32х32) в base64
        /// </summary>
        public string Logo { get; set; }

        public bool WeekMenuIsActive { get; set; }

        public string Address { get; set; }

        public string Phone { get; set; }

        public bool IsActive { get; set; }

        public bool DeferredOrder { get; set; }

        public double? DaylyCorpOrderSum { get; set; }

        public TimeSpan? OrderAbortTime { get; set; }

        [Display(Name = "Город")]
        public long CityId { get; set; }

        [Display(Name = "Город")]
        public CityModel City { get; set; }

        public List<CityModel> Cities { get; set; }

        public PaymentTypeEnum PaymentMethod { get; set; }

        /// <summary>
        /// Минимальная сумма заказа
        /// </summary>
        public double? MinimumOrderSum { get; set; }

        /// <summary>
        /// Условия доставки
        /// </summary>
        public string DeliveryComment { get; set; }

        /// <summary>
        /// Регионы доставки
        /// </summary>
        public string Regions { get; set; }

        /// <summary>
        /// Кухня
        /// </summary>
        public List<KitchenModel> Kitchens { get; set; }
    }
}