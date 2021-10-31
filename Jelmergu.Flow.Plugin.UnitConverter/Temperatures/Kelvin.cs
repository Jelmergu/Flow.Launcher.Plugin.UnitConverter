namespace Jelmergu.Flow.Plugin.UnitConverter.Temperatures
{
    public class Kelvin : Temperature, IBaseUnit
    {
        public Kelvin(decimal temp) : base(temp)
        {
        }

        public decimal toCelsius()
        {
            return Value + (decimal) -273.15;
        }

        public decimal toFahrenheit()
        {
            return Value * Fahrenheit.Factor - (decimal) 459.67;
        }

        public decimal toKelvin()
        {
            return Value;
        }

        public override Kelvin ToBase() => this;

        public static UnitNamer<Kelvin> GetUnitNamer()
        {
            return new UnitNamer<Kelvin>("K", typeof(Kelvin));
        }
    }
}
