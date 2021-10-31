using Jelmergu.Flow.Plugin.UnitConverter.Temperatures;
using NUnit.Framework;

namespace Jelmergu.Flow.Plugin.UnitConverter.Test.Temperatures
{
    public class CelsiusTest
    {
        private Celsius _sut;

        [Test]
        public void ToBaseTest()
        {
            _sut = new Celsius(0);
            Assert.AreEqual(273.15, _sut.ToBase().toKelvin());
        }
    }
}
