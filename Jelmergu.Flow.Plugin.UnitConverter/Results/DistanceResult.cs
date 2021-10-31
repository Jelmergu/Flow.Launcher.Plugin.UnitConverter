using System.Collections.Generic;
using Flow.Launcher.Plugin;

namespace Jelmergu.Flow.Plugin.UnitConverter.Results
{
    public class DistanceResult : List<Result>
    {
        private string icon = MultiunitCalculator.Images.Images.LengthIcon;

        public DistanceResult(Length.Length distance) : base(9)
        {
            Add(new Result
            {
                Title    = "Metre",
                SubTitle = distance.ToBase().ToMetres().ToString(),
                IcoPath  = icon
            });
            Add(new Result
            {
                Title    = "Mile",
                SubTitle = distance.ToBase().ToMiles().ToString(),
                IcoPath  = icon
            });
            Add(new Result
            {
                Title    = "Foot",
                SubTitle = distance.ToBase().ToFeet().ToString(),
                IcoPath  = icon
            });
            Add(new Result
            {
                Title    = "Inch",
                SubTitle = distance.ToBase().ToInches().ToString(),
                IcoPath  = icon
            });
            Add(new Result
            {
                Title    = "Yard",
                SubTitle = distance.ToBase().ToYard().ToString(),
                IcoPath  = icon
            });
            Add(new Result
            {
                Title    = "Nautical Mile",
                SubTitle = distance.ToBase().ToNauticalMile().ToString(),
                IcoPath  = icon
            });
            Add(new Result
            {
                Title    = "Astronomical Mile",
                SubTitle = distance.ToBase().ToAstronomical().ToString(),
                IcoPath  = icon
            });
            Add(new Result
            {
                Title    = "Lightyear",
                SubTitle = distance.ToBase().ToLightYear().ToString(),
                IcoPath  = icon
            });
            Add(new Result
            {
                Title    = "Parsec",
                SubTitle = distance.ToBase().ToParsec().ToString(),
                IcoPath  = icon
            });
        }
    }
}
