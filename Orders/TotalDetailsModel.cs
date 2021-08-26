using System.Collections.Generic;

namespace ITWebNet.Food.Core.DataContracts.Common
{
    public class TotalDetailsModel
    {
        public OrderModel Order { get; set; }
        
        public double BasePrice { get; set; }
        
        public double TotalSumm { get; set; }
        
        public double Discount { get; set; }
        
        public double Delivery { get; set; }
        
        List<OrderStatusModel> OrderStatus { get; set; }
    }
}
