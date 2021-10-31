using System;
using Jelmergu.Flow.Plugin.UnitConverter.Length;
using Jelmergu.Flow.Plugin.UnitConverter.Test.Datasets.Length;
using NUnit.Framework;

namespace Jelmergu.Flow.Plugin.UnitConverter.Test.Length
{
    public class MetreTest
    {
        private Metre _sut;

        [TestCaseSource(typeof(LengthDataset), nameof(LengthDataset.Set))]
        public void ToMetresTest(LengthStruct data)
        {
            _sut = new Metre(data.Metre);
            Assert.AreEqual(data.Metre, _sut.ToMetres());
        }

        [TestCaseSource(typeof(LengthDataset), nameof(LengthDataset.Set))]
        public void ToInchesTest(LengthStruct data)
        {
            _sut = new Metre(data.Metre);
            Assert.AreEqual(Round(data.Inch), Round(_sut.ToInches()));
        }

        [TestCaseSource(typeof(LengthDataset), nameof(LengthDataset.Set))]
        public void ToFeetTest(LengthStruct data)
        {
            _sut = new Metre(data.Metre);
            Assert.AreEqual(data.Foot, _sut.ToFeet());
        }

        [TestCaseSource(typeof(LengthDataset), nameof(LengthDataset.Set))]
        public void ToYardTest(LengthStruct data)
        {
            _sut = new Metre(data.Metre);
            Assert.AreEqual(data.Yard, _sut.ToYard());
        }

        [TestCaseSource(typeof(LengthDataset), nameof(LengthDataset.Set))]
        public void ToMilesTest(LengthStruct data)
        {
            _sut = new Metre(data.Metre);
            Assert.AreEqual(Round(data.Mile), Round(_sut.ToMiles()));
        }

        [TestCaseSource(typeof(LengthDataset), nameof(LengthDataset.Set))]
        public void ToNauticalMileTest(LengthStruct data)
        {
            _sut = new Metre(data.Metre);
            Assert.AreEqual(Round(data.NauticalMile), Round(_sut.ToNauticalMile()));
        }

        [TestCaseSource(typeof(LengthDataset), nameof(LengthDataset.Set))]
        public void ToAstronomicalTest(LengthStruct data)
        {
            _sut = new Metre(data.Metre);
            Assert.AreEqual(Round(data.Astronomical), Round(_sut.ToAstronomical()));
        }

        [TestCaseSource(typeof(LengthDataset), nameof(LengthDataset.Set))]
        public void ToLightYearTest(LengthStruct data)
        {
            _sut = new Metre(data.Metre);
            Assert.AreEqual(data.LightYear, _sut.ToLightYear());
        }

        [TestCaseSource(typeof(LengthDataset), nameof(LengthDataset.Set))]
        public void ToParsecTest(LengthStruct data)
        {
            _sut = new Metre(data.Metre);
            Assert.AreEqual(data.Parsec, _sut.ToParsec());
        }

        public Decimal Round(decimal d)
        {
            return Decimal.Round(d, 12);
        }
    }
}
