namespace ITWebNet.Food.Core.DataContracts.Common
{
    public class PostOrderRequest
    {
        public OrderModel Order { get; set; }
        
        public string SuccessURL { get; set; }
        
        public string FailureURL { get; set; }
        
        public string PaymentType { get; set; }
    }
}
