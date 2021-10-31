using Jelmergu.Flow.Plugin.UnitConverter;

namespace Jelmergu.Flow.Plugin.UnitConverter.Length
{
    public class Mile : Length
    {
        public const decimal SI = (decimal) 0.000621371;

        public Mile(decimal length) : base(length)
        {
            SIFactor = SI;
        }

        public static UnitNamer<Length> GetUnitNamer()
        {
            return new UnitNamer<Length>("mi", typeof(Mile));
        }
    }
}
