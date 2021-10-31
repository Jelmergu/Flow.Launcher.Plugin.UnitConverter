using Jelmergu.Flow.Plugin.UnitConverter.Temperatures;
using Jelmergu.Flow.Plugin.UnitConverter.Test.Datasets.Temperature;
using NUnit.Framework;

namespace Jelmergu.Flow.Plugin.UnitConverter.Test.Temperatures
{
    public class KelvinTest
    {
        private Kelvin _sut;

        [TestCaseSource(typeof(TemperatureDataset), nameof(TemperatureDataset.Set))]
        public void ToFahrenheitTest(TemperatureStruct data)
        {
            _sut = new Kelvin(data.Kelvin);
            Assert.AreEqual(data.Fahrenheit, _sut.toFahrenheit());
        }

        [TestCaseSource(typeof(TemperatureDataset), nameof(TemperatureDataset.Set))]
        public void ToCelsiusTest(TemperatureStruct data)
        {
            _sut = new Kelvin(data.Kelvin);
            Assert.AreEqual(data.Celsius, _sut.toCelsius());
        }

        [TestCaseSource(typeof(TemperatureDataset), nameof(TemperatureDataset.Set))]
        public void ToKelvinTest(TemperatureStruct data)
        {
            _sut = new Kelvin(data.Kelvin);
            Assert.AreEqual(data.Kelvin, _sut.toKelvin());
        }
    }
}
