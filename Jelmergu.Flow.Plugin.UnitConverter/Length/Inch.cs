namespace Jelmergu.Flow.Plugin.UnitConverter.Length
{
    public class Inch : Length
    {
        public const decimal SI = (decimal) 39.3701;

        public Inch(decimal length) : base(length)
        {
            SIFactor = SI;
        }

        public static UnitNamer<Length> GetUnitNamer()
        {
            return new UnitNamer<Length>("in", typeof(Inch));
        }
    }
}
