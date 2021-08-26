using System.ComponentModel;

namespace ITWebNet.Food.Core.DataContracts.Common
{
    public enum SearchType
    {
        [Description("имени заказчика")]
        SearchByName,
        [Description("телефону заказчика")]
        SearchByPhone,
        [Description("названию заказанного блюда")]
        SearchByDish,
        [Description("номеру заказа")]
        SearchByOrderNumber,
        [Description("названию кафе")]
        SearchByCafe,
    }
}
