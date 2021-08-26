using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace ITWebNet.Food.Core.DataContracts.Common
{
    public class OrderModel
    {
        public Int64 Id { get; set; }
        
        public string CreatorLogin { get; set; }
        
        public long CreatorId { get; set; }
        
        public long? BanketId { get; set; }
        
        public DateTime Create { get; set; }
        
        public List<OrderItemModel> OrderItems { get; set; }
        
        public Int64? DeliveryAddressId { get; set; }

        public DeliveryAddressModel DeliveryAddress { get; set; }

        public string PhoneNumber { get; set; }

        public bool PreOrder { get; set; }
        /// <summary>
        /// Коммент к оплате
        /// </summary>
        public string OddMoneyComment { get; set; }
        
        public string Comment { get; set; }
        
        public Int64? CompanyOrderId { get; set; }
        
        public double? TotalSum { get; set; }
        
        public int? itemsCount { get; set; }

        public DateTime? DeliverDate { get; set; }
        
        public Int64? Status { get; set; }
        
        public Int64 CafeId { get; set; }

        public CafeModel Cafe { get; set; }

        public bool IsDeleted { get; set; }
        
        public UserModel Creator { get; set; }
        
        public OrderInfoModel OrderInfo { get; set; }
        /// <summary>
        /// тип оплаты
        /// </summary>
        public string PayType { get; set; }

        /// <summary>
        /// Комментарий менеджера
        /// </summary>
        public string ManagerComment { get; set; }


        [Display(Name = "Город")]
        public long CityId { get; set; }

        [Display(Name = "Город")]
        public CityModel City { get; set; }

        public List<CityModel> Cities { get; set; }

    }
}
