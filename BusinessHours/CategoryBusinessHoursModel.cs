namespace ITWebNet.Food.Core.DataContracts.Manager
{
    /// <summary>
    /// Представляет рабочее время категории.
    /// </summary>

    public class CategoryBusinessHoursModel : BusinessHoursModel
    {
        /// <summary>
        /// Возвращает или задает идентификатор кафе.
        /// </summary>

        public long CafeId { get; set; }

        /// <summary>
        /// Возвращает или задает идентификатор категории.
        /// </summary>

        public long CategoryId { get; set; }
    }
}
