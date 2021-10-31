using System;
using Jelmergu.Flow.Plugin.UnitConverter.Length;
using NUnit.Framework;

namespace Jelmergu.Flow.Plugin.UnitConverter.Test.Length
{
    public class YardTest
    {
        [Test]
        public void ToBaseTest()
        {
        var _sut = new Yard(1);
        Assert.AreEqual((decimal) 0.9144, Math.Round(_sut.ToBase().Value, 4));
        }
    }
}
