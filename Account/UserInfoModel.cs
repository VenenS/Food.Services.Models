using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using ITWebNet.Food.Core.DataContracts.Common;

namespace ITWebNet.Food.Core.DataContracts.Account
{
    public class UserInfoModel
    {
        [Required(ErrorMessage = "Обязательное поле")]
        [Display(Name = "Email")]
        [RegularExpression(@"^([a-zA-Z0-9_\.-]+)@([A-Za-z0-9_\.-]+)\.([A-Za-z\.]{2,6})$", 
            ErrorMessage = "Некорректный Email")]
        [StringLength(70, ErrorMessage = "Максимальное количество символов для электронного адреса - {1}")]
        public virtual string Email { get; set; }

        public virtual bool EmailConfirmed { get; set; }

        [Required(ErrorMessage = "Обязательное поле")]
        [Display(Name = "Телефон")]
        [RegularExpression(@"^\+7\s\(9([0-9]{2})\)\s([0-9]{3})\s[0-9]{4}$", ErrorMessage = "Код оператора должен начинаться с 9. Номер телефона должен содержать 10 цифр")]
        public virtual string PhoneNumber { get; set; }

        public virtual bool PhoneNumberConfirmed { get; set; }

        public virtual string SmsCode { get; set; }

        public virtual bool IsSendCode { get; set; }

        public virtual bool TwoFactorEnabled { get; set; }

        [Display(Name = "Отображаемое имя")]
        [StringLength(50, ErrorMessage = "Максимальное количество символов для отображаемого имени - {1}")]
        [RegularExpression(@"^[а-яА-ЯёЁa-zA-Z0-9@\.\s]+$", 
            ErrorMessage = "В имени могу присутствовать только буквы и цифры, символы @ и .")]
        public virtual string UserFullName { get; set; }

        [Display(Name = "Адрес доставки")]
        public virtual string DefaultAddress { get; set; }

        public bool HasPassword { get; set; }

        public long? DefaultAddressId { get; set; }
        [Display(Name = "Город")]
        public virtual long City { get; set; }
        [Display(Name = "Улица")]
        public virtual string Street { get; set; }
        [Display(Name = "Дом")]
        public virtual string House { get; set; }
        [Display(Name = "Строение")]
        public virtual string Building { get; set; }
        [Display(Name = "Квартира")]
        public virtual string Flat { get; set; }
        [Display(Name = "Офис")]
        public virtual string Office { get; set; }
        [Display(Name = "Подъезд")]
        [StringLength(2, ErrorMessage = "Максимальное количество символов для кода - {1}")]
        public virtual string Entrance { get; set; }
        [Display(Name = "Этаж")]
        [StringLength(4, ErrorMessage = "Максимальное количество символов для кода - {1}")]
        public virtual string Storey { get; set; }
        [StringLength(10, ErrorMessage = "Максимальное количество символов для кода - {1}")]
        [Display(Name = "Домофон")]
        public virtual string Intercom { get; set; }
        [Display(Name = "Комментарий к адресу")]
        public virtual string AddressComment { get; set; }
        public double PersonalPoints { get; set; }

        public double ReferralPoints { get; set; }

        public double PercentOfOrder { get; set; }

        [Display(Name = "Реферальная ссылка")]
        public string UserReferralLink { get; set; }

        public List<UserInCompanyModel> UserInCompanies { get; set; }

        public bool IsSendEmailConfirmationCode { get; set; }

        public virtual string EmailCode { get; set; }
    }
}
