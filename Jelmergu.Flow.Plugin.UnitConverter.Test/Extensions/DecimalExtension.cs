using System;

namespace Jelmergu.Flow.Plugin.UnitConverter.Test.Extensions
{
    public static class DecimalExtension
    {
        public static decimal Round(this string input, int decimals)
        {
            return Decimal.Round(Decimal.Parse(input), decimals);
        }
    }
}
