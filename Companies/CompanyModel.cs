using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ComponentModel.DataAnnotations;

namespace ITWebNet.Food.Core.DataContracts.Common
{
    
    public class CompanyModel
    {
        
        public Int64 Id { get; set; }

        
        [Display(Name = "Название")]
        [Required(ErrorMessage = "Введите название компании")]
        [StringLength(25, MinimumLength = 3, ErrorMessage = "Длина названия компании должна быть {2}-{1} символов")]
        public string Name { get; set; }

        
        [Display(Name = "Полное название")]
        [StringLength(100, ErrorMessage = "Полное название компании должна быть не больше {1} символов")]
        public string FullName { get; set; }

        
        [Display(Name = "Основной адрес доставки")]
        public Int64? DeliveryAddressId { get; set; }

        
        [Display(Name = "Адрес доставки")]
        public DeliveryAddressModel DeliveryAddress { get; set; }

        
        [Display(Name = "Юридический адрес")]
        public Int64? JuridicalAddressId { get; set; }

        
        [Display(Name = "Юридический адрес")]
        public DeliveryAddressModel JuridicalAddress { get; set; }

        [Display(Name = "Город")]
        public long CityId { get; set; }

        [Display(Name = "Город")]
        public CityModel City { get; set; }

        public List<CityModel> Cities { get; set; }

        public List<DeliveryAddressModel> Addresses { get; set; }

        
        public bool IsDeleted { get; set; }

        
        public bool IsActive { get; set; }

        /// <summary>
        ///  Включает/отключает оповещение пользователей компании о новых заказах по СМС
        /// </summary>
        public bool SmsNotify { get; set; } = false;

    }
}
