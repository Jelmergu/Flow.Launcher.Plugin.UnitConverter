using System;
using System.Windows.Input;

namespace Jelmergu.Flow.Plugin.UnitConverter.Time
{
    public class Minute : Time
    {
        public Minute(decimal time) : base(time)
        {
        }

        public override Second ToBase()
        {
            return new Second(Value * 60);
        }

        public static UnitNamer<Time> GetUnitNamer()
        {
            return new UnitNamer<Time>("m", typeof(Minute));
        }
    }
}
