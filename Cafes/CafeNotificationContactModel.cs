using System;

namespace ITWebNet.Food.Core.DataContracts.Common
{
    public class CafeNotificationContactModel
    {
        public Int64 Id { get; set; }
        
        public Int64 CafeId { get; set; }
        
        public NotificationChannelModel NotificationChannel { get; set; }
        
        public string NotificationContact { get; set; }
    }
}
