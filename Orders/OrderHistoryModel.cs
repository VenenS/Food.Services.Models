using System;
using System.Collections.Generic;

namespace ITWebNet.Food.Core.DataContracts.Common
{
    public class OrderHistoryModel
    {
        public OrderModel Order { get; set; }

        public CafeModel Cafe;

        public List<OrderStatusEnum> AvailableStatuses { get; set; }

        public List<FoodDishModel> Dishes;

        public BanketModel Banket { get; set; }
    }
}
