using ITWebNet.Food.Core.DataContracts.Common;
using System;
using System.Collections.Generic;

namespace ITWebNet.Food.Core.DataContracts.Manager
{
    /// <summary>
    /// Представляет данные кафе.
    /// </summary>

    public class CafeInfoModel
    {
        /// <summary>
        /// Возвращает или задает идентификатор кафе.
        /// </summary>
        public long CafeId { get; set; }

        /// <summary>
        /// Возвращает или задает описание кафе.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Возвращает или задает короткое описание кафе.
        /// </summary>
        public string ShortDescription { get; set; }

        /// <summary>
        /// Возвращает возможность заказы еды на неделю
        /// </summary>
        /// <returns></returns>
        public bool WeekMenuIsActive { get; set; }

        /// <summary>
        /// Возвращает или задает иконку кафе
        /// </summary>
        public string CafeIcon { get; set; }

        /// <summary>
        /// Возвращает или задает логотип кафе
        /// </summary>
        public string Logotype { get; set; }
        
        /// <summary>
        /// Возвращает или задает шапку кафе
        /// </summary>
        public string HeadPicture { get; set; }

        /// <summary>
        /// Возвращает или задает адрес для отправки уведомлений
        /// </summary>
        public string NotificationContact { get; set; }

        public double DailyCorpOrderSum { get; set; }

        public string Phone { get; set; }
        
        
        public string Address { get; set; }

         
        public bool DeferredOrder { get; set; }


        /// <summary>
        /// Возвращает или задает врмея отмены заказов из корпоративного заказа 
        /// если не набралась минимальная сумма заказов по определенному адресу
        /// </summary>
        public TimeSpan? OrderAbortTime { get; set; }

        public PaymentTypeEnum PaymentMethod { get; set; }

        public int? AverageDeliveryTime { get; set; }

        public double? MinimumOrderSum { get; set; }

        public string DeliveryComment { get; set; }

        public string Regions { get; set; }

        public List<KitchenModel> Kitchens { get; set; }
    }
}
