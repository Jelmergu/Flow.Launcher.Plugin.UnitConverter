using System;
using Jelmergu.Flow.Plugin.UnitConverter.Length;
using NUnit.Framework;

namespace Jelmergu.Flow.Plugin.UnitConverter.Test.Length
{
    public class LightYearTest
    {
        [Test]
        public void ToBaseTest()
        {
            var _sut = new LightYear(1);
            Assert.AreEqual((decimal) 9460730472801122, Math.Round(_sut.ToBase().Value));
        }
    }
}
