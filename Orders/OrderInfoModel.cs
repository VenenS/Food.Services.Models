using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ITWebNet.Food.Core.DataContracts.Common
{
    public class OrderInfoModel
    {
        public long Id { get; set; }
        public double DeliverySumm { get; set; }
        public double DiscountSumm { get; set; }
        public double TotalSumm { get; set; }
        public long? PaymentType { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? LastUpdate { get; set; }
        public long? LastUpdateBy { get; set; }
        public string OrderEmail { get; set; }
        public string OrderPhone { get; set; }
        public string OrderAddress { get; set; }
        public OrderModel Order { get; set; }
        public UserModel User { get; set; }
        [Display(Name = "Город")]
        public long CityId { get; set; }
        [Display(Name = "Город")]
        public CityModel City { get; set; }
        public List<CityModel> Cities { get; set; }

    }
}
