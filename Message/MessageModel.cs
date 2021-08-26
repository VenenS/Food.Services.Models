using System;
using System.Collections.Generic;
using System.Text;

namespace Notifications.Services.Sms.Models
{
    public class MessageModel
    {
        /// <summary>
        /// Подпись (имя отправителя)
        /// </summary>
        public string Sign { get; set; }

        /// <summary>
        /// Текст сообщения
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// Имя приложения
        /// </summary>
        public string AppName { get; set; }

        /// <summary>
        /// Среда приложения
        /// </summary>
        public string Environment { get; set; }

        /// <summary>
        /// Номер телефона (79990000000)
        /// </summary>
        public string Number { get; set; }
    }
}
