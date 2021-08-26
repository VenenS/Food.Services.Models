using ITWebNet.Food.Core.DataContracts.Admin;
using System;

namespace ITWebNet.Food.Core.DataContracts.Common
{
    public class DishInMenuHistoryModel
    {
        public long Id { get; set; }

        public long DishID { get; set; }

        public string Type { get; set; }

        public double? Price { get; set; }

        public DateTime? LastUpdDate { get; set; }

        public UserAdminModel Creator { get; set; }

    }
}
