using System;
using System.Collections.Generic;

namespace ITWebNet.Food.Core.DataContracts.Common
{
    /// <summary>
    /// Содержит данные для формирования страницы отчета
    /// (сейчас используется для Куратора в "Файл отчета")
    /// </summary>
    public class ReportDataModel
    {
        public List<CompanyOrderDataModel> OrdersData { get; set; }
        public List<UserOrderDataModel> IndividualOrdersData { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public CafeModel Cafe { get; set; }
        public double? TotalSumm { get; set; }
    }

    public class CompanyOrderDataModel
    {
        public CompanyModel Company { get; set; }
        public string CompanyAddress { get; set; }
        public CompanyOrderModel CompanyOrder { get; set; }
        public List<UserOrderDataModel> Orders { get; set; }
        public double TotalPrice { get; set; }
        public string OrderStatusReport { get; set; }
    }

    public class UserOrderDataModel
    {
        public List<OrderDataModel> Orders { get; set; }
        public double TotalPrice { get; set; }
        public long Id { get; set; }
    }

    public class OrderDataModel
    {
        public UserModel User { get; set; }
        public OrderModel Order { get; set; }
        public List<FoodDishDataModel> OrderDishes { get; set; }
        public double TotalPrice { get; set; }
        public DeliveryAddressModel Delivery { get; set; }
        public string OrderStatusReport { get; set; }
    }

    public class FoodDishDataModel
    {
        public FoodDishModel Dish { get; set; }
        public int ItemCount { get; set; }
        public double ItemTotalPrice { get; set; }
        public int? ItemDiscount { get; set; }
        public string CategoryName { get; set; }
    }
}
