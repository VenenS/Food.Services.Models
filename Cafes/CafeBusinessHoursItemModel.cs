using System;

namespace ITWebNet.Food.Core.DataContracts.Manager
{
    /// <summary>
    /// Представляет элемент рабочего времени кафе.
    /// </summary>

    public class CafeBusinessHoursItemModel
    {
        /// <summary>
        /// Возвращает или задает время закрытия кафе.
        /// </summary>
        
        public DateTime ClosingTime { get; set; }

        /// <summary>
        /// Возвращает или задает время открытия кафе.
        /// </summary>
        
        public DateTime OpeningTime { get; set; }
    }
}
