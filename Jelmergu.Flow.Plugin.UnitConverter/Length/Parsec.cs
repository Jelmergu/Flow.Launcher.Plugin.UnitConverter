using Jelmergu.Flow.Plugin.UnitConverter;

namespace Jelmergu.Flow.Plugin.UnitConverter.Length
{
    public class Parsec : Length
    {
        public const decimal SI = (decimal) 3.2407792896664E-17;

        public Parsec(decimal length) : base(length)
        {
            SIFactor = SI;
        }

        public static UnitNamer<Length> GetUnitNamer()
        {
            return new UnitNamer<Length>("pc", typeof(Parsec));
        }
    }
}
