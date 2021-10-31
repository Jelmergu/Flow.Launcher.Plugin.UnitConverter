using System.Collections.Generic;
using System.Linq;
using Flow.Launcher.Plugin;
using Jelmergu.Flow.Plugin.UnitConverter.Resolvers;
using Jelmergu.Flow.Plugin.UnitConverter.Test.Extensions;
using NUnit.Framework;

namespace Jelmergu.Flow.Plugin.UnitConverter.Test.Resolvers
{
    public class TemperatureResolverTest : ResolverTest
    {
        private List<Result> CreateResult(string input)
        {
            return new TemperatureResolver().Resolve(CreateQuery(input), new List<string>(), new List<string> {input});
        }

        [Test]
        public void ResolveKelvinTest()
        {
            Assert.AreEqual("1", CreateResult("1K").First(r => r.Title.Equals("Kelvin")).SubTitle);
        }

        [Test]
        public void ResolveCelsiusTest()
        {
            Assert.AreEqual("1", CreateResult("1C").First(r => r.Title.Equals("Kelvin")).SubTitle);
        }

        [Test]
        public void ResolveFahrenheitTest()
        {
            Assert.AreEqual("255.928", CreateResult("1f").First(r => r.Title.Equals("Kelvin")).SubTitle.Round(3));
        }
    }
}
