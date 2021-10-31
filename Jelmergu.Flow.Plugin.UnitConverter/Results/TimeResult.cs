using System.Collections.Generic;
using Flow.Launcher.Plugin;

namespace Jelmergu.Flow.Plugin.UnitConverter.Results
{
    public class TimeResult : List<Result>
    {

        public TimeResult() : base(0)
        {
        }

        private void CreateResult(string title, string value)
        {
            Add(new Result
            {
                Title = title,
                SubTitle = value,
                IcoPath = MultiunitCalculator.Images.Images.TimeIcon
            });
        }

        public TimeResult(Time.Time time) : base(3)
        {
            CreateResult("Seconds", time.ToBase().ToSeconds().ToString());
            CreateResult("Minutes", time.ToBase().ToMinutes().ToString());
            CreateResult("Hours", time.ToBase().ToHours().ToString());
            CreateResult("Days", time.ToBase().ToDays().ToString());
        }
    }
}
