namespace Jelmergu.Flow.Plugin.UnitConverter.Time
{
    public class Day : Time
    {
        public static UnitNamer<Time> GetUnitNamer()
        {
            return new UnitNamer<Time>("day", typeof(Day));
        }

        public Day(decimal time) : base(time)
        {
        }

        public override Second ToBase()
        {
            return new Second(Value * 86400);
        }
    }
}
