using ITWebNet.Food.Core.DataContracts.Admin;
using System;

namespace ITWebNet.Food.Core.DataContracts.Common
{
    public class ScheduleModel
    {
        public Int64 Id { get; set; }
        
        public Int64 DishID { get; set; }
        
        public string Type { get; set; }
        
        public string MonthDays { get; set; }
        
        public string WeekDays { get; set; }
        
        public DateTime? BeginDate { get; set; }
        
        public DateTime? EndDate { get; set; }
        
        public DateTime? OneDate { get; set; }
        
        public double? Price { get; set; }
        
        public DateTime? CreateDate { get; set; }
        
        public UserAdminModel Creator { get; set; }
    }
}
