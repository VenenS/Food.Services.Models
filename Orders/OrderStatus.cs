using System;
using System.Collections.Generic;

namespace ITWebNet.Food.Core.DataContracts.Common
{
    public struct OrderStatusModel
    {
        public OrderStatusModel(OrderModel model, string err)
        {
            ExceptionList = new List<Exception> { new Exception(err) };
            Order = model;
        }

        public OrderModel Order { get; set; }
        
        public List<Exception> ExceptionList { get; set; }
    }
}
