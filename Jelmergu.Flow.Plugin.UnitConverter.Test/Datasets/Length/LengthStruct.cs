namespace Jelmergu.Flow.Plugin.UnitConverter.Test.Datasets.Length
{
    public struct LengthStruct
    {
        public LengthStruct(decimal metre, decimal inch, decimal foot, decimal yard, decimal mile, decimal nauticalMile,
            decimal                 astronomical, decimal lightYear, decimal parsec)
        {
            Metre        = metre;
            Inch         = inch;
            Foot         = foot;
            Yard         = yard;
            Mile         = mile;
            NauticalMile = nauticalMile;
            Astronomical = astronomical;
            LightYear    = lightYear;
            Parsec       = parsec;
        }

        public decimal Metre        { get; }
        public decimal Inch         { get; }
        public decimal Foot         { get; }
        public decimal Yard         { get; }
        public decimal Mile         { get; }
        public decimal NauticalMile { get; }
        public decimal Astronomical { get; }
        public decimal LightYear    { get; }
        public decimal Parsec       { get; }
    }
}
