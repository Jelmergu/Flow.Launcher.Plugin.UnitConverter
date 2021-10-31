namespace Jelmergu.Flow.Plugin.UnitConverter.Length
{
    public class Metre : Length, IBaseUnit
    {
        public Metre(decimal length) : base(length)
        {
        }

        public decimal ToMetres()
        {
            return Value;
        }

        public decimal ToInches()
        {
            return Value * Inch.SI;
        }

        public decimal ToFeet()
        {
            return Value * Foot.SI;
        }

        public decimal ToYard()
        {
            return Value * Yard.SI;
        }

        public decimal ToMiles()
        {
            return Value * Mile.SI;
        }

        public decimal ToNauticalMile()
        {
            return Value * NauticalMile.SI;
        }

        public decimal ToAstronomical()
        {
            return Value * Astronomical.SI;
        }

        public decimal ToLightYear()
        {
            return Value * LightYear.SI;
        }

        public decimal ToParsec()
        {
            return Value * Parsec.SI;
        }

        public override Metre ToBase()
        {
            return this;
        }

        public static UnitNamer<Metre> GetUnitNamer()
        {
            return new UnitNamer<Metre>("m", typeof(Metre));
        }
    }
}
