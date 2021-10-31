namespace Jelmergu.Flow.Plugin.UnitConverter.Length
{
    public class Yard : Length
    {
        public const decimal SI = (decimal) 1.09361;

        public Yard(decimal length) : base(length)
        {
            SIFactor = SI;
        }

        public static UnitNamer<Length> GetUnitNamer()
        {
            return new UnitNamer<Length>("yd", typeof(Yard));
        }
    }
}
