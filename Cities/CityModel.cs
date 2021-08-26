namespace ITWebNet.Food.Core.DataContracts.Common
{
    public class CityModel
    {
        public long Id { get; set; }

        public string Name { get; set; }

        public bool IsActive { get; set; }

        public RegionModel Region { get; set; }
    }
}
