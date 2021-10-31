using System;
using Jelmergu.Flow.Plugin.UnitConverter.Temperatures;
using NUnit.Framework;

namespace Jelmergu.Flow.Plugin.UnitConverter.Test.Temperatures
{
    public class FahrenheitTest
    {
        private Fahrenheit _sut;

        [Test]
        public void ToBaseTest()
        {
            _sut = new Fahrenheit(0);
            Assert.AreEqual(255.372, Math.Round(_sut.ToBase().toKelvin(), 3));
        }
    }
}
