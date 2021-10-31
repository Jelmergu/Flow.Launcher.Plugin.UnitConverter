using System;
using System.Collections.Generic;

namespace Jelmergu.Flow.Plugin.UnitConverter.Test.Datasets.Length
{
    public class LengthDataset
    {
        public static List<LengthStruct> Set = new List<LengthStruct>
        {
            new LengthStruct(
                (decimal) 1,
                (decimal) 39.3701,
                (decimal) 3.28084,
                (decimal) 1.09361,
                (decimal) 0.000621371,
                (decimal) 0.000539957,
                (decimal) 6.68459e-12,
                (decimal) 1.057000834E-16,
                (decimal) 3.24077928967E-17),
            new LengthStruct(
                (decimal) 0.0253999863,
                (decimal) 1.00000000062963,
                (decimal) 0.083333291052492,
                (decimal) 0.027777679017543,
                (decimal) 0.0000157828148872173,
                (decimal) 0.0000137149004025891,
                (decimal) 0.000000000000169788494421117,
                (decimal) 2.6847806703E-18,
                (decimal) 8.231574956E-19),
            new LengthStruct(
                (decimal) 0.3047999902,
                (decimal) 12.00000609417302,
                (decimal) 0.999999999847768,
                (decimal) 0.333332317282622,
                (decimal) 0.0001893938747105642,
                (decimal) 0.0001645788883084214,
                (decimal) 0.000000000002037462966491018,
                (decimal) 3.22173843845E-17,
                (decimal) 9.8778949573E-18),
        };

        public LengthDataset()
        {
            Console.Out.WriteLine((decimal) 0.3047999902 * (decimal) 39.3701);
            Console.Out.WriteLine((decimal) 0.3047999902 * (decimal) 3.28084);
            Console.Out.WriteLine((decimal) 0.3047999902 * (decimal) 1.09361);
            Console.Out.WriteLine((decimal) 0.3047999902 * (decimal) 0.000621371);
            Console.Out.WriteLine((decimal) 0.3047999902 * (decimal) 0.000539957);
            Console.Out.WriteLine((decimal) 0.3047999902 * (decimal) 6.68459e-12);
            Console.Out.WriteLine((decimal) 0.3047999902 * (decimal) 1.057e-16);
            Console.Out.WriteLine((decimal) 0.3047999902 * (decimal) 3.24078e-17);
        }
    }
}
