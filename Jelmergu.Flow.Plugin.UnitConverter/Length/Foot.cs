namespace Jelmergu.Flow.Plugin.UnitConverter.Length
{
    public class Foot : Length
    {
        public const decimal SI = (decimal) 3.28084;

        public Foot(decimal length) : base(length)
        {
            SIFactor = SI;
        }

        public static UnitNamer<Length> GetUnitNamer()
        {
            return new UnitNamer<Length>("ft", typeof(Foot));
        }
    }
}
