using System;
using System.ComponentModel.DataAnnotations;

namespace ITWebNet.Food.Core.DataContracts.Manager
{
    public class CompanyOrderScheduleModel
    {
        public Int64 Id { get; set; }
        
        public Int64 CompanyId { get; set; }
        
        public Int64 CompanyDeliveryAdress { get; set; }
        
        public bool? IsActive { get; set; }
        
        [DataType(DataType.Date)]
        public DateTime? BeginDate { get; set; }
        
        [DataType(DataType.Date)]
        public DateTime? EndDate { get; set; }
        
        [DataType(DataType.Time)]
        public DateTime OrderStartTime { get; set; }
        
        [DataType(DataType.Time)]
        public DateTime OrderStopTime { get; set; }
        
        [DataType(DataType.Time)]
        public DateTime OrderSendTime { get; set; }
        
        public DateTime? CreateDate { get; set; }
        
        public Int64? CreatorId { get; set; }
        
        public DateTime? LastUpdDate { get; set; }
        
        public Int64? LastUpdateByUserId { get; set; }
        
        [Required(ErrorMessage = "Кафе не выбрано")]
        public Int64 CafeId { get; set; }
    }
}
