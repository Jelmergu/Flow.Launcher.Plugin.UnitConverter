using System;
using System.Collections.Generic;
using System.Linq;
using Flow.Launcher.Plugin;
using Jelmergu.Flow.Plugin.UnitConverter.Resolvers;
using Jelmergu.Flow.Plugin.UnitConverter.Test.Extensions;
using NUnit.Framework;

namespace Jelmergu.Flow.Plugin.UnitConverter.Test.Resolvers
{
    public class LengthResolverTest : ResolverTest
    {
        private List<Result> CreateResult(string input)
        {
            return new LengthResolver().Resolve(CreateQuery(input), new List<string>(), new List<string> {input});
        }

        [Test]
        public void ResolveMetreTest()
        {
            Assert.AreEqual("1", CreateResult("1m").First(r => r.Title.Equals("Metre")).SubTitle);
        }

        [Test]
        public void ResolveInch()
        {
            Assert.AreEqual(0.0254d,
                CreateResult("1in").First(r => r.Title.Equals("Metre")).SubTitle.Round(4));
        }
    }
}
