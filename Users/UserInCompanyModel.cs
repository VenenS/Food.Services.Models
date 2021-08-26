namespace ITWebNet.Food.Core.DataContracts.Common
{
    public class UserInCompanyModel
    {
        public long CompanyId { get; set; }

        public long UserId { get; set; }

        public UserModel User { get; set; }
        public CompanyModel Company { get; set; }
        public long? DeliveryAddressId { get; set; }
        public long Id { get; set; }
    }
}