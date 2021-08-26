using System;
using System.Collections.Generic;

namespace ITWebNet.Food.Core.DataContracts.Common
{
    public class RestOfCategory
    {
        /// <summary>
        /// Идентификатор компании, в рамках которой осуществяется заказ
        /// </summary>
        public long? CompanyId { get; set; }
        public long CategoryId { get; set; }
        public ICollection<long> DishIds { get; set; }
        public string RestName { get; set; }
    }
}
