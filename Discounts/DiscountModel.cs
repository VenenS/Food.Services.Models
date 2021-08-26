using ITWebNet.Food.Core.DataContracts.Common;
using System;

namespace ITWebNet.Food.Core.DataContracts.Manager
{
    public class DiscountModel
    {
        public Int64 Id { get; set; }
        
        public Int64 CafeId { get; set; }
        
        public int Value { get; set; }
        
        public Int64? CompanyId { get; set; }
        
        public Int64? UserId { get; set; }
        
        public DateTime BeginDate { get; set; }
        
        public DateTime? EndDate { get; set; }
        
        public DateTime CreateDate { get; set; }
        
        public Int64? CreatorId { get; set; }
        
        public DateTime? LastUpdDate { get; set; }
        
        public Int64? LastUpdateByUserId { get; set; }
        
        public CafeModel Cafe { get; set; }
    }
}
