namespace Food.Services.Contracts
{
    internal class CafeOrderNotificationModel
    {
        public long CafeId { get; set; }
        public long OrderId { get; set; }
        public long UserId { get; set; }
    }
}