using System;

namespace ITWebNet.Food.Core.DataContracts.Admin
{
    public class UserRoleModel
    {
        public Int64 Id { get; set; }
        
        public Int64 UserId { get; set; }
        
        public Int64 RoleId { get; set; }
    }
}
