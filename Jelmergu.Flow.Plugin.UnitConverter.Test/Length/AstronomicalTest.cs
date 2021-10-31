using System;
using Jelmergu.Flow.Plugin.UnitConverter.Length;
using NUnit.Framework;

namespace Jelmergu.Flow.Plugin.UnitConverter.Test.Length
{
    public class AstronomicalTest
    {
        [Test]
        public void ToBaseTest()
        {
            var _sut = new Astronomical(1);
            Assert.AreEqual((decimal) 149597870691, Math.Round(_sut.ToBase().Value));
        }
    }
}
