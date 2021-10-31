using System;
using Jelmergu.Flow.Plugin.UnitConverter.Length;
using NUnit.Framework;

namespace Jelmergu.Flow.Plugin.UnitConverter.Test.Length
{
    public class InchTest
    {
        [Test]
        public void ToBaseTest()
        {
            var _sut = new Inch(1);
            Assert.AreEqual((decimal) 0.0254, Math.Round(_sut.ToBase().Value, 4));
        }
    }
}
