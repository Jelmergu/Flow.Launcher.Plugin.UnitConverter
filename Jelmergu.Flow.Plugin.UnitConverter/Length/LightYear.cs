namespace Jelmergu.Flow.Plugin.UnitConverter.Length
{
    public class LightYear : Length
    {
        public const decimal SI = (decimal) 1.057000834E-16;

        public LightYear(decimal length) : base(length)
        {
            SIFactor = SI;
        }

        public static UnitNamer<Length> GetUnitNamer()
        {
            return new UnitNamer<Length>("ly", typeof(LightYear));
        }
    }
}
