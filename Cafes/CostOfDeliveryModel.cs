using System;

namespace ITWebNet.Food.Core.DataContracts.Common
{
    public class CostOfDeliveryModel
    {
        public Int64 Id { get; set; }
        
        public Int64 CafeId { get; set; }
        
        public double OrderPriceFrom { get; set; }
        
        public double OrderPriceTo { get; set; }
        
        public double DeliveryPrice { get; set; }
        
        public DateTime? CreateDate { get; set; }
        
        public Int64? CreatorId { get; set; }
        
        public DateTime? LastUpdDate { get; set; }
        
        public Int64? LastUpdateByUserId { get; set; }

        /// <summary>
        /// Тип заказов, для которых будет применяться стоимость доставки.
        /// true - для корпоративных, false - для персональных
        /// </summary>
        public bool ForCompanyOrders { get; set; }
    }
}
