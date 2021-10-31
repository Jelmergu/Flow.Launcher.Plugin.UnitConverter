using System;
using System.Collections.Generic;
using Flow.Launcher.Plugin;
using Jelmergu.Flow.Plugin.UnitConverter.Length;
using Jelmergu.Flow.Plugin.UnitConverter.Results;

namespace Jelmergu.Flow.Plugin.UnitConverter.Resolvers
{
    public class LengthResolver : UnitResolver<Metre, Length.Length>
    {
        public static BaseUnitMap<Metre, Length.Length> BaseUnitMap { get; } =
            new BaseUnitMap<Metre, Length.Length>(
                Metre.GetUnitNamer(),
                Astronomical.GetUnitNamer(),
                Foot.GetUnitNamer(),
                Inch.GetUnitNamer(),
                LightYear.GetUnitNamer(),
                Mile.GetUnitNamer(),
                NauticalMile.GetUnitNamer(),
                Parsec.GetUnitNamer(),
                Yard.GetUnitNamer()
            );


        public override List<Result> CreateResult(decimal value)
        {
            return new DistanceResult(new Metre(value));
        }

        public override Length.Length MapToUnit(string value, string unit)
        {
            if (unit == Metre.GetUnitNamer().Identifier) return new Metre(Decimal.Parse(value));
            foreach (var u in BaseUnitMap.Units)
            {
                if (unit == u.Identifier)
                    return u.Unit.GetConstructor(new[] {typeof(decimal)}).Invoke(new object[] {Decimal.Parse(value)}) as Length.Length;
            }

            return null;
        }
    }
}
