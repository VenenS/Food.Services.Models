using System;
using System.Collections.Generic;

namespace ITWebNet.Food.Core.DataContracts.Common
{
    public class DishFilterModel
    {
        public List<long> DishIds { get; set; }
        public DateTime? Date { get; set; }
    }
}