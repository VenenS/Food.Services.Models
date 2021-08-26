using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace ITWebNet.Food.Core.DataContracts.Admin
{
    
    public class UserWithLoginModel
    {
        
        public Int64 Id { get; set; }

        
        [Display(Name = "Имя")]
        public string Name { get; set; }

        
        public Int64? DeliveryAddressId { get; set; }

        
        [Display(Name = "Телефон")]
        public string PhoneNumber { get; set; }

        
        public string DisplayName { get; set; }

        [Required(ErrorMessage = "Введите E-mail")]
        [Display(Name = "Email")]
        [RegularExpression(@"^([a-zA-Z0-9_\.-]+)@([A-Za-z0-9_\.-]+)\.([A-Za-z\.]{2,6})$", 
            ErrorMessage = "Некорректный Email")]
        [StringLength(70, ErrorMessage = "Максимальное количество символов для электронного адреса - {1}")]
        public string EmailAdress { get; set; }

        
        [Display(Name = "Отображаемое имя")]
        [RegularExpression(@"^[а-яА-ЯёЁa-zA-Z0-9@\.\s]+$", 
            ErrorMessage = "В имени могу присутствовать только буквы и цифры, символы @ и .")]
        [StringLength(50, ErrorMessage = "Максимальное количество символов для отображаемого имени - {1}")]
        public string FullName { get; set; }

        [Display(Name = "Имя")]
        [StringLength(50, ErrorMessage = "Максимальное количество символов для имени - {1}")]
        
        public string UserFirstName { get; set; }

        [Display(Name = "Фамилия")]
        [StringLength(50, ErrorMessage = "Максимальное количество символов для фамилии - {1}")]
        
        public string UserSurname { get; set; }

        
        public string Password { get; set; }

        
        public bool Lockout { get; set; }

        
        public bool IsDeleted { get; set; }
    }
}

