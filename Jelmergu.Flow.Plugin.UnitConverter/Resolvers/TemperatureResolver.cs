using System;
using System.Collections.Generic;
using Flow.Launcher.Plugin;
using Jelmergu.Flow.Plugin.UnitConverter.Results;
using Jelmergu.Flow.Plugin.UnitConverter.Temperatures;

namespace Jelmergu.Flow.Plugin.UnitConverter.Resolvers
{
    public class TemperatureResolver : UnitResolver<Kelvin, Temperature>
    {
        public static BaseUnitMap<Kelvin, Temperature> BaseUnitMap { get; } =
            new BaseUnitMap<Kelvin, Temperature>(
                Kelvin.GetUnitNamer(),
                Fahrenheit.GetUnitNamer(),
                Celsius.GetUnitNamer()
            );

        public override List<Result> CreateResult(decimal   value)
        {
            return new TemperatureResult(new Kelvin(value));
        }

        public override Temperature  MapToUnit(string value, string unit)
        {
            switch (unit)
            {
                case "K":
                    return new Kelvin(Decimal.Parse(value));
                case "C":
                    return new Celsius(Decimal.Parse(value));
                case "F":
                    return new Fahrenheit(Decimal.Parse(value));
            }

            return null;
        }
    }
}
