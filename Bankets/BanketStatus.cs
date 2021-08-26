namespace ITWebNet.Food.Core.DataContracts.Common
{
    public enum BanketStatus
    {
        /// <summary>
        /// Заказ оформляется
        /// </summary>
        Projected = 1,
        /// <summary>
        /// Заказ наполняется
        /// </summary>
        Formed = 2,
        /// <summary>
        /// Заказ готовится
        /// </summary>
        Preparing = 3,
        /// <summary>
        /// Заказ завершен
        /// </summary>
        Closed = 4
    }
}
