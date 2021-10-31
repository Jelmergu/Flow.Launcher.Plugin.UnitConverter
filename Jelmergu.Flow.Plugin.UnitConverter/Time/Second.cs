namespace Jelmergu.Flow.Plugin.UnitConverter.Time
{
    public class Second : Time, IBaseUnit
    {
        public override Second ToBase() => this;

        public Second(decimal seconds) : base(seconds)
        {
        }

        public static UnitNamer<Second> GetUnitNamer()
        {
            return new UnitNamer<Second>("s", typeof(Second));
        }

        public override string ToString()
        {
            return Value + "s";
        }

        public decimal ToSeconds()
        {
            return Value;
        }

        public decimal ToMinutes()
        {
            return Value / 60;
        }

        public decimal ToHours()
        {
            return Value / 3600;
        }

        public decimal ToDays()
        {
            return Value / 86400;
        }
    }
}
