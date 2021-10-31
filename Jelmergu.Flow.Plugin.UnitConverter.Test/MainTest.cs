using System;
using System.Linq;
using Flow.Launcher.Plugin;
using NUnit.Framework;

namespace Jelmergu.Flow.Plugin.UnitConverter.Test
{
    public class MainTest
    {
        [Test]
        public void TestWithUnknownUnit()
        {
            var query = new Query("10l", "10l", new []{"10l"});
            Assert.Throws<NullReferenceException>(() => new UnitConverter().Query(query));
        }

        [Test]
        public void TestWithKnownUnit()
        {
            var query = new Query("10k", "10k", new []{"10k"});
            var result = new UnitConverter().Query(query);
            Assert.AreEqual("10", result.First(r => r.Title.Equals("Kelvin")).SubTitle);
        }

        [Test]
        public void TestWithSumOfKnownUnits()
        {
            var query  = new Query("10k + 5K", "10k + 5K", new []{"10k", "+", "5K"});
            var result = new UnitConverter().Query(query);
            Assert.AreEqual("15", result.First(r => r.Title.Equals("Kelvin")).SubTitle);
        }
    }
}
