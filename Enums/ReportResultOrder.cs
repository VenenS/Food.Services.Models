using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITWebNet.Food.Core.DataContracts.Common
{
    /// <summary>
    /// Порядок результатов сортировки в отчете.
    /// </summary>
    public enum ReportResultOrder
    {
        /// <summary>
        /// Сортировка по возрастанию.
        /// </summary>
        Ascending = 0,

        /// <summary>
        /// Сортировка по убыванию.
        /// </summary>
        Descending
    }
}
