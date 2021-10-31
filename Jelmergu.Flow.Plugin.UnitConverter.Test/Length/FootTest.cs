using System;
using Jelmergu.Flow.Plugin.UnitConverter.Length;
using NUnit.Framework;

namespace Jelmergu.Flow.Plugin.UnitConverter.Test.Length
{
    public class FootTest
    {
        [Test]
        public void ToBaseTest()
        {
            var _sut = new Foot(1);
            Assert.AreEqual((decimal) 0.3048, Math.Round(_sut.ToBase().Value, 4));
        }
    }
}
