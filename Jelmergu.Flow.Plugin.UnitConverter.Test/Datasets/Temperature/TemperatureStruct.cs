namespace Jelmergu.Flow.Plugin.UnitConverter.Test.Datasets.Temperature
{
    public readonly struct TemperatureStruct
    {
        public decimal Celsius { get; }
        public decimal Kelvin { get; }
        public decimal Fahrenheit { get; }

        public TemperatureStruct(decimal kelvin, decimal celsius, decimal fahrenheit)
        {
            Kelvin     = kelvin;
            Celsius    = celsius;
            Fahrenheit = fahrenheit;
        }
    }
}
