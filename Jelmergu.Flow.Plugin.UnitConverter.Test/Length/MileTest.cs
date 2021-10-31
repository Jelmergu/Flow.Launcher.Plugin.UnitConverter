using System;
using Jelmergu.Flow.Plugin.UnitConverter.Length;
using NUnit.Framework;

namespace Jelmergu.Flow.Plugin.UnitConverter.Test.Length
{
    public class MileTest
    {
        [Test]
        public void ToBaseTest()
        {
            var _sut = new Mile(1);
            Assert.AreEqual((decimal) 1609.34, Math.Round(_sut.ToBase().Value, 2));
        }
    }
}
