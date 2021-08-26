using System;
using System.ComponentModel.DataAnnotations;

namespace ITWebNet.Food.Core.DataContracts.Admin
{
    /// <summary>
    /// Предоставляет доступ ко всем данным пользователя системы, как для создания, так и для редактирования
    /// </summary>
    public class UserAdminModel
    {
        /// <summary>
        /// Количество неуспешных попыток входа
        /// </summary>
        public virtual int? AccessFailedCount { get; set; }

        public Int64? DeliveryAddressId { get; set; }

        /// <summary>
        /// Email пользователя, он же логин
        /// </summary>
        [Required, EmailAddress]
        public virtual string Email { get; set; }

        /// <summary>
        /// Подтвержден email или нет
        /// </summary>
        public virtual bool EmailConfirmed { get; set; }

        /// <summary>
        /// Идентификатор пользователя
        /// </summary>
        public virtual long Id { get; set; }

        /// <summary>
        /// Признак блокировки пользователя
        /// </summary>
        public virtual bool LockoutEnabled { get; set; }

        /// <summary>
        /// Дата окончания блокировки пользователя в формате UTC, 
        /// любое время в прошлом означает, что блокировка снята.
        /// </summary>
        public virtual DateTime? LockoutEndDateUtc { get; set; }

        /// <summary>
        /// Номер телефона
        /// </summary>
        [Phone]
        public virtual string PhoneNumber { get; set; }

        /// <summary>
        /// Подтвержден телефон или нет
        /// </summary>
        public virtual bool PhoneNumberConfirmed { get; set; }

        /// <summary>
        /// Включение/отключение СМС-оповещений о заказах
        /// </summary>
        public virtual bool SmsNotify { get; set; } = false;

        /// <summary>
        /// Признак двухфакторной аутентификации
        /// </summary>
        public virtual bool TwoFactorEnabled { get; set; }

        /// <summary>
        /// Фамилия, имя пользователя или иное его обозначение, выводимое в письмах и иных уведомнеиях
        /// </summary>
        public virtual string UserFullName { get; set; }

        public double PersonalPoints { get; set; }
        public double ReferralPoints { get; set; }
        public double PercentOfOrder { get; set; }
        public string UserReferralLink { get; set; }

        /// <summary>
        /// Дата создания
        /// </summary>
        public virtual DateTime? CreateDate { get; set; }

        /// <summary>
        /// Id пользователя, который создал запись
        /// </summary>
        public virtual long? CreatedBy { get; set; }

        /// <summary>
        /// Дата последнего обновления
        /// </summary>
        public virtual DateTime? LastUpdateDate { get; set; }

        /// <summary>
        /// Id пользователя, который последним обновил запись
        /// </summary>
        public virtual long? LastUpdateBy { get; set; }

        /// <summary>
        /// Признак того, считается ли пользователь удаленным
        /// </summary>
        public virtual bool IsDeleted { get; set; }
    }
}
