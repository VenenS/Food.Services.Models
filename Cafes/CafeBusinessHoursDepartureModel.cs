using System;
using System.Collections.Generic;

namespace ITWebNet.Food.Core.DataContracts.Manager
{
    /// <summary>
    /// Представляет отклонение рабочего времени кафе.
    /// </summary>

    public class CafeBusinessHoursDepartureModel
    {
        /// <summary>
        /// Возвращает или задает дату.
        /// </summary>
        
        public DateTime Date { get; set; }

        /// <summary>
        /// Возвращает или задает значение, которое указывает, является ли день выходным.
        /// </summary>
        
        public bool IsDayOff { get; set; }

        /// <summary>
        /// Возвращает или задает список элементов рабочего времени кафе.
        /// </summary>
        
        public List<CafeBusinessHoursItemModel> Items { get; set; }
    }
}
