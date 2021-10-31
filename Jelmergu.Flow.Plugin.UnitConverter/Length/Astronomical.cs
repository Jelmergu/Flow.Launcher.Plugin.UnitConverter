namespace Jelmergu.Flow.Plugin.UnitConverter.Length
{
    public class Astronomical : Length
    {
        public const decimal SI = (decimal) 6.6845871226706e-12;

        public Astronomical(decimal length) : base(length)
        {
            SIFactor = SI;
        }

        public static UnitNamer<Length> GetUnitNamer()
        {
            return new UnitNamer<Length>("AU", typeof(Astronomical));
        }
    }
}
