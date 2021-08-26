using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ITWebNet.Food.Core.DataContracts.Common
{
    public class CompanyOrderModel
    {
        public class DeliveryCost
        {
            public string Address { get; set; }
            public double Cost { get; set; }
        }

        public Int64 Id { get; set; }
        
        public DateTime? CreateDate { get; set; }
        
        public Int64? DeliveryAddressId { get; set; }
        
        public DateTime? DeliveryDate { get; set; }
        
        public Int64 CafeId { get; set; }
        
        public Int64 CompanyId { get; set; }
        
        public string ContactEmail { get; set; }
        
        public string ContactPhone { get; set; }
        
        public DateTime? OrderOpenDate { get; set; }
        
        public DateTime? OrderAutoCloseDate { get; set; }
        
        public Int64 OrderStatus { get; set; }
        
        public double TotalPrice { get; set; }
        
        public List<OrderModel> UserOrders { get; set; }

        public bool IsDeleted { get; set; }
        
        public CompanyModel Company { get; set; }
        
        public CafeModel Cafe { get; set; }

        /// <summary>
        /// Общая стоимость доставки корпоративного ордера
        /// </summary>
        public double TotalDeliveryCost { get; set; }

        public string CafeFullName { get; set; }

        /// <summary>
        /// Детализация стоимости доставки на каждый из адресов компании.
        /// </summary>
        public List<DeliveryCost> DeliveryCostDetails { get; set; }
    }
}
