using System;

namespace ITWebNet.Food.Core.DataContracts.Common
{
    /// <summary>
    /// Тип сортировки для отчётов
    /// </summary>
    public enum ReportSortType
    {
        /// <summary>
        /// По времени поступления
        /// </summary>
        OrderByDate,
        /// <summary>
        /// По статусам
        /// </summary>
        OrderByStatus,
        /// <summary>
        /// По сумме заказа
        /// </summary>
        OrderByPrice,
        /// <summary>
        /// По номеру заказа
        /// </summary>
        OrderByOrderNumber,
        /// <summary>
        /// По названию кафе
        /// </summary>
        OrderByCafeName,
        /// <summary>
        /// По сотруднику
        /// </summary>
        OrderByEmployeeName,
        /// <summary>
        /// По сотрудникам
        /// </summary>
        OrderByAllEmployee,
        /// <summary>
        /// По времени доствки
        /// </summary>
        OrderByDeliveryDate
    }
}
