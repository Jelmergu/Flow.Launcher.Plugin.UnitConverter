using System;
using Jelmergu.Flow.Plugin.UnitConverter.Length;
using NUnit.Framework;

namespace Jelmergu.Flow.Plugin.UnitConverter.Test.Length
{
    public class NauticalMileTest
    {
        [Test]
        public void ToBaseTest()
        {
            var _sut = new NauticalMile(1);
            Assert.AreEqual((decimal) 1852, Math.Round(_sut.ToBase().Value));
        }
    }
}
