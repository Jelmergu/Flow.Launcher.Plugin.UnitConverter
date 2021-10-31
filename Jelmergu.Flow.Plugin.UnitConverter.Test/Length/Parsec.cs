using System;
using Jelmergu.Flow.Plugin.UnitConverter.Length;
using NUnit.Framework;

namespace Jelmergu.Flow.Plugin.UnitConverter.Test.Length
{
    public class ParsecTest
    {
        [Test]
        public void ToBaseTest()
        {
            var _sut = new Parsec(1);
            Assert.AreEqual((decimal) 30856775812765311, Math.Round(_sut.ToBase().Value));
        }
    }
}
