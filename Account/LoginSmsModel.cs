namespace Food.Services.Models
{
    /// <summary>
    /// Модель входа на сайт через СМС код
    /// </summary>
    public class LoginSmsModel
    {
        /// <summary>
        /// Телефон
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// Код из СМС
        /// </summary>
        public string SmsCode { get; set; }
    }
}
