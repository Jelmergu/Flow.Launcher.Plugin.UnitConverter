
namespace Jelmergu.Flow.Plugin.UnitConverter.Temperatures
{
    public class Celsius : Temperature
    {
        public Celsius(decimal temp) : base(temp)
        {
        }

        public override Kelvin ToBase()
        {
            return new Kelvin(Value + (decimal) 273.15);
        }

        public static UnitNamer<Temperature> GetUnitNamer()
        {
            return new UnitNamer<Temperature>("C", typeof(Celsius));
        }

    }
}
