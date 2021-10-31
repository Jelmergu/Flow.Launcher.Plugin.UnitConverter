using System;
using System.Collections.Generic;
using Flow.Launcher.Plugin;
using Jelmergu.Flow.Plugin.UnitConverter.Results;
using Jelmergu.Flow.Plugin.UnitConverter.Time;

namespace Jelmergu.Flow.Plugin.UnitConverter.Resolvers
{
    public class TimeResolver : UnitResolver<Second, Time.Time>
    {
        public static BaseUnitMap<Second, Time.Time> BaseUnitMap { get; } =
            new BaseUnitMap<Second, Time.Time>(
                Second.GetUnitNamer(),
                Minute.GetUnitNamer(),
                Hour.GetUnitNamer(),
                Day.GetUnitNamer()
            );

        public override List<Result> CreateResult(decimal value)
        {
            return new TimeResult(new Second(value));
        }

        public override Time.Time MapToUnit(string value, string unit)
        {
            if (unit == Second.GetUnitNamer().Identifier) return new Second(Decimal.Parse(value));
            foreach (var u in BaseUnitMap.Units)
            {
                if (unit == u.Identifier)
                    return u.Unit.GetConstructor(new[] {typeof(decimal)})
                        .Invoke(new object[] {Decimal.Parse(value)}) as Time.Time;
            }

            return null;
        }
    }
}
