using System.Collections.Generic;

namespace ITWebNet.Food.Core.DataContracts.Manager
{
    /// <summary>
    /// Представляет рабочее время.
    /// </summary>

    public abstract class BusinessHoursModel
    {
        /// <summary>
        /// Возвращает или задает список отклонений рабочего времени кафе.
        /// </summary>
        
        public List<CafeBusinessHoursDepartureModel> Departures { get; set; }

        /// <summary>
        /// Возвращает или задает рабочее время кафе в пятницу.
        /// </summary>
        
        public List<CafeBusinessHoursItemModel> Friday { get; set; }

        /// <summary>
        /// Возвращает или задает рабочее время кафе в понедельник.
        /// </summary>
        
        public List<CafeBusinessHoursItemModel> Monday { get; set; }

        /// <summary>
        /// Возвращает или задает рабочее время кафе в субботу.
        /// </summary>
        
        public List<CafeBusinessHoursItemModel> Saturday { get; set; }

        /// <summary>
        /// Возвращает или задает рабочее время кафе в воскресенье.
        /// </summary>
        
        public List<CafeBusinessHoursItemModel> Sunday { get; set; }

        /// <summary>
        /// Возвращает или задает рабочее время кафе в четверг.
        /// </summary>
        
        public List<CafeBusinessHoursItemModel> Thursday { get; set; }

        /// <summary>
        /// Возвращает или задает рабочее время кафе во вторник.
        /// </summary>
        
        public List<CafeBusinessHoursItemModel> Tuesday { get; set; }

        /// <summary>
        /// Возвращает или задает рабочее время кафе в среду.
        /// </summary>
        
        public List<CafeBusinessHoursItemModel> Wednesday { get; set; }
    }
}
