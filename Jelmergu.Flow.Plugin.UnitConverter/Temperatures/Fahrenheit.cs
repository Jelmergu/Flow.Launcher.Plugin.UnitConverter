namespace Jelmergu.Flow.Plugin.UnitConverter.Temperatures
{
    public class Fahrenheit : Temperature
    {
        public const decimal Factor = (decimal)1.8;

        public Fahrenheit(decimal temp) : base(temp)
        {
        }

        public override Kelvin ToBase()
        {
            return new Kelvin((Value + (decimal) 459.67) / Factor);
        }

        public static UnitNamer<Temperature> GetUnitNamer()
        {
            return new UnitNamer<Temperature>("F", typeof(Fahrenheit));
        }
    }
}
