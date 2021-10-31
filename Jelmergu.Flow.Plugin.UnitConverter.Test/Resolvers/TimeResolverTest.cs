using System;
using System.Collections.Generic;
using System.Linq;
using Flow.Launcher.Plugin;
using Jelmergu.Flow.Plugin.UnitConverter.Resolvers;
using Jelmergu.Flow.Plugin.UnitConverter.Test.Extensions;
using NUnit.Framework;

namespace Jelmergu.Flow.Plugin.UnitConverter.Test.Resolvers
{
    public class TimeResolverTest : ResolverTest
    {
        private List<Result> CreateResult(string input)
        {
            return new TimeResolver()
                .Resolve(CreateQuery(input),
                    new List<string>(),
                    new List<string> {input}
                );
        }

        [Test]
        public void ResolveSecondTest()
        {
            Assert.AreEqual("1", CreateResult("1s").First(r => r.Title.Equals("Seconds")).SubTitle);
            Assert.AreEqual(0.016667,
                CreateResult("1s").First(r => r.Title.Equals("Minutes")).SubTitle.Round(6));
            Assert.AreEqual(0.000278,
                CreateResult("1s").First(r => r.Title.Equals("Hours")).SubTitle.Round(6));
        }

        [Test]
        public void ResolveMinuteTest()
        {
            Assert.AreEqual("60", CreateResult("1m").First(r => r.Title.Equals("Seconds")).SubTitle);
            Assert.AreEqual("1", CreateResult("1m").First(r => r.Title.Equals("Minutes")).SubTitle);
            Assert.AreEqual(0.016667, CreateResult("1m").First(r => r.Title.Equals("Hours")).SubTitle.Round(6));
        }

        [Test]
        public void ResolveHourTest()
        {
            Assert.AreEqual("3600", CreateResult("1h").First(r => r.Title.Equals("Seconds")).SubTitle);
            Assert.AreEqual("60", CreateResult("1h").First(r => r.Title.Equals("Minutes")).SubTitle);
            Assert.AreEqual("1", CreateResult("1h").First(r => r.Title.Equals("Hours")).SubTitle);
        }

        [Test]
        public void ResolveDayTest()
        {
            Assert.AreEqual("86400", CreateResult("1day").First(r => r.Title.Equals("Seconds")).SubTitle);
            Assert.AreEqual("1440", CreateResult("1day").First(r => r.Title.Equals("Minutes")).SubTitle);
            Assert.AreEqual("24", CreateResult("1day").First(r => r.Title.Equals("Hours")).SubTitle);
            Assert.AreEqual("1", CreateResult("1day").First(r => r.Title.Equals("Days")).SubTitle);
        }
    }
}
