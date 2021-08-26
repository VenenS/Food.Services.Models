namespace ITWebNet.Food.Core.DataContracts.Manager
{
    /// <summary>
    /// Представляет рабочее время кафе.
    /// </summary>

    public class CafeBusinessHoursModel : BusinessHoursModel
    {
        /// <summary>
        /// Возвращает или задает идентификатор кафе.
        /// </summary>

        public long CafeId { get; set; }
    }
}
