namespace Jelmergu.Flow.Plugin.UnitConverter.Time
{
    public class Hour : Time
    {
        public static UnitNamer<Time> GetUnitNamer()
        {
            return new UnitNamer<Time>("h", typeof(Hour));
        }

        public Hour(decimal time) : base(time)
        {
        }

        public override Second ToBase()
        {
            return new Second(Value * 3600);
        }


    }
}
