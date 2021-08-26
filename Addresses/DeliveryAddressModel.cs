using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ITWebNet.Food.Core.DataContracts.Common
{

    public class DeliveryAddressModel
    {
        public Int64 Id { get; set; }

        [Required(ErrorMessage = "Обязательное поле")]
        [StringLength(120)]
        [Display(Name = "Город")]
        public string CityName { get; set; }

        [Required(ErrorMessage = "Обязательное поле")]
        [StringLength(120)]
        [Display(Name = "Улица")]
        public string StreetName { get; set; }

        [Required(ErrorMessage = "Обязательное поле")]
        [StringLength(10)]
        [Display(Name = "Дом")]
        public string HouseNumber { get; set; }

        [StringLength(10)]
        [Display(Name = "Номер корпуса")]
        public string BuildingNumber { get; set; }

        [StringLength(10)]
        [Display(Name = "Квартира")]
        public string FlatNumber { get; set; }

        [Display(Name = "Подъезд")]
        public string EntranceNumber { get; set; }

        [Display(Name = "Этаж")]
        public string StoreyNumber { get; set; }

        [Display(Name = "Домофон")]
        public string IntercomNumber { get; set; }

        [Required(ErrorMessage = "Обязательное поле")]
        [StringLength(10)]
        [Display(Name = "Номер квартиры/офиса")]
        public string OfficeNumber { get; set; }
        
        [StringLength(512)]
        [Display(Name = "Дополнительная информация")]
        public string ExtraInfo { get; set; }
        
        [StringLength(6)]
        [Display(Name = "Почтовый индекс")]
        public string PostalCode { get; set; }
        
        [Display(Name = "Комментарий к адресу")]
        public string AddressComment { get; set; }
        
        [StringLength(256, ErrorMessage = "Максимальное количество символов {1}")]
        [Display(Name = "Адрес")]
        public string RawAddress { get; set; }
        
        [Display(Name = "Показывать при заказе")]
        public DisplayAddressType DisplayType { get; set; }

        [Display(Name = "Город")]
        public long CityId { get; set; }

        [Display(Name = "Город")]
        public CityModel City { get; set; }

        public List<CityModel> Cities { get; set; }

        public bool IsActive { get; set; }
        
        public long CompanyAddressId { get; set; }
    }
}
