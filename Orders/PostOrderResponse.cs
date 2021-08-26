using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace ITWebNet.Food.Core.DataContracts.Common
{
    public class PostOrderResponse
    {
        public string PaymentURL { get; set; }
        public OrderStatusModel OrderStatus { get; set; }
    }
}
