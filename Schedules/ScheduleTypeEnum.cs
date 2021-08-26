using System.Runtime.Serialization;

namespace ITWebNet.FoodServiceManager
{
    [DataContract(Name = "ScheduleType")]
    public enum ScheduleTypeEnum
    {
        [EnumMember]
        Daily = 'D',
        [EnumMember]
        Weekly = 'W',
        [EnumMember]
        Monthly = 'M',
        [EnumMember]
        Simply = 'S',
        [EnumMember]
        Exclude = 'E'
    }
}
