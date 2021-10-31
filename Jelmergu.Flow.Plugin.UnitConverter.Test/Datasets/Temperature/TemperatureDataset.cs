using System.Collections.Generic;

namespace Jelmergu.Flow.Plugin.UnitConverter.Test.Datasets.Temperature
{
    public class TemperatureDataset
    {
        public static List<TemperatureStruct> Set { get; } = new List<TemperatureStruct>
        {
            new TemperatureStruct(0, (decimal) -273.150, (decimal) -459.670),
            new TemperatureStruct((decimal) 273.15, 0, 32),
            new TemperatureStruct((decimal) 310.928, (decimal) 37.778, (decimal)100.0004),
            new TemperatureStruct((decimal) 373.15, 100, 212)
        };
    }
}
