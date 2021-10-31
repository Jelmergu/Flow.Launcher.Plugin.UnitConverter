namespace Jelmergu.Flow.Plugin.UnitConverter.Length
{
    public class NauticalMile : Length
    {
        public const decimal SI = (decimal) 0.000539957;

        public NauticalMile(decimal length) : base(length)
        {
            SIFactor = SI;
        }

        public static UnitNamer<Length> GetUnitNamer()
        {
            return new UnitNamer<Length>("NM", typeof(NauticalMile));
        }
    }
}
