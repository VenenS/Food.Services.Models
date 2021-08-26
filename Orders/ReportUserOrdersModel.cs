using ITWebNet.Food.Core.DataContracts.Common;
using System;
using System.Collections.Generic;

namespace Food.Services.Contracts
{
    /// <summary>
    /// Заказы сотрудника за переиод
    /// </summary>
    public class ReportUserOrdersModel
    {
        public double TotalSumm { get; set; } = 0;
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public List<OrderModel> Orders { get; set; }
        public UserModel User { get; set; }
        public RoleModel Role { get; set; }
    }
}
