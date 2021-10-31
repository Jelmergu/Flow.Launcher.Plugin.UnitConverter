using System.Collections.Generic;
using Flow.Launcher.Plugin;
using Jelmergu.Flow.Plugin.UnitConverter.Temperatures;

namespace Jelmergu.Flow.Plugin.UnitConverter.Results
{
    public class TemperatureResult : List<Result>
    {
        public TemperatureResult() : base(0)
        {
        }

        public TemperatureResult(Temperature temperature) : base(3)
        {
            Add(new Result
            {
                Title    = "Kelvin",
                SubTitle = temperature.ToBase().toKelvin().ToString(),
                IcoPath  = MultiunitCalculator.Images.Images.TemperatureIcon
            });
            Add(new Result
            {
                Title    = "Celsius",
                SubTitle = temperature.ToBase().toCelsius().ToString(),
                IcoPath  = MultiunitCalculator.Images.Images.TemperatureIcon
            });
            Add(new Result
            {
                Title    = "Fahrenheit",
                SubTitle = temperature.ToBase().toFahrenheit().ToString(),
                IcoPath  = MultiunitCalculator.Images.Images.TemperatureIcon
            });
        }
    }
}
