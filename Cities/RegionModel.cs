using System.Collections.Generic;

namespace ITWebNet.Food.Core.DataContracts.Common
{
    /// <summary>
    /// Модель субъкта/региона (область, край, республика)
    /// </summary>
    public class RegionModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public List<CityModel> Cities { get; set; } = new List<CityModel>();
    }
}
