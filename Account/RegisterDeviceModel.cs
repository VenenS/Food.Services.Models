using System.ComponentModel.DataAnnotations;

namespace ITWebNet.Food.Core.DataContracts.Account
{
    public class RegisterDeviceModel
    {
        [Required]
        public string DeviceUUID { get; set; }
    }
}
