using ITWebNet.Food.Core.DataContracts.Common;
using System;
using System.Collections.Generic;

namespace ITWebNet.Food.Core.DataContracts.Common
{
    public class CompanyServersModel
    {
        /// <summary>
        /// Время на которое эта модель актуальна.
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Идентификатор компании.
        /// </summary>
        public long CompanyId { get; set; }

        /// <summary>
        /// Имя компании.
        /// </summary>
        public string CompanyName { get; set; }

        /// <summary>
        /// Список идентификаторов кафе, которые обслуживают эту компанию.
        /// </summary>
        public List<long> ServingCafes { get; set; }
    }
}
