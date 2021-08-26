using System;

namespace ITWebNet.Food.Core.DataContracts.Common
{
    public class NotificationModel
    {
        /// <summary>
        /// Идентификатор уведомления
        /// </summary>
        public Int64 Id { get; set; }

        /// <summary>
        /// Идентификатор заказа, относительно которого сделано уведомление
        /// Может быть пустым, если уведомление было не о заказе
        /// </summary>
        public Int64? OrderId { get; set; }

        /// <summary>
        /// Идентификатор пользователя, относительно которого сделано уведомление
        /// Может быть пустым, если уведомление не было связано с пользователем
        /// </summary>
        public Int64? UserId { get; set; }

        /// <summary>
        /// Идентификатор кафе, относительно которого сделано уведомление
        /// Может быть пустым, если уведомление не было связано с кафе
        /// </summary>
        public Int64? CafeId { get; set; }

        /// <summary>
        /// Идентификатор канала отправки
        /// </summary>
        public NotificationChannelModel NotificationChannel { get; set; }

        /// <summary>
        /// Идентификатор типа сообщения
        /// </summary>
        public NotificationType NotificationType { get; set; }

        /// <summary>
        /// Адрес, кому было отправлено сообщение
        /// Допустимые значение: email, номер сотового
        /// </summary>
        public string SendContact { get; set; }

        /// <summary>
        /// Дата отправки уведомления
        /// </summary>
        public DateTime SendDate { get; set; }

        /// <summary>
        /// Статус отправки сообщения
        /// Допустимые значения: S - success, E - error
        /// </summary>
        public string SendStatus { get; set; }

        /// <summary>
        /// Текст ошибки отправки, если таковая есть
        /// </summary>
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Дата создания записи
        /// </summary>
        public DateTime CreateDate { get; set; }

        /// <summary>
        /// Кем создана
        /// </summary>
        public Int64 CreatedBy { get; set; }

        /// <summary>
        /// Дата последнего обновления записи
        /// </summary>
        public DateTime? LastUpdDate { get; set; }

        /// <summary>
        /// Кем обновлена
        /// </summary>
        public Int64? LastUpdateByUserId { get; set; }
    }
}
