using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using Flow.Launcher.Plugin;
using Jelmergu.Flow.Plugin.UnitConverter.Length;
using Jelmergu.Flow.Plugin.UnitConverter.Resolvers;
using Jelmergu.Flow.Plugin.UnitConverter.Temperatures;
using Jelmergu.Flow.Plugin.UnitConverter.Time;

namespace Jelmergu.Flow.Plugin.UnitConverter
{
    public class ResolverFactory
    {
        public bool IsResolvable(Query query)
        {
            var unitNamers =
                BaseUnitMaps.Aggregate("", (current, baseUnitMap) => current + baseUnitMap.GetUnitNamers());
            return query.Terms.All(term =>
                Regex.Match(term, "([0-9]+[" + unitNamers + "]{1}[ ]?)?|([-+*/]{1})?").Success);
        }

        public List<Result> Resolve(Query query)
        {
            var operators = new Regex("[0-9A-Za-z ]+").Split(query.Search).Where(s => !s.Equals("")).ToList();
            var values    = new Regex("[-+*/ ]+").Split(query.Search).Where(s => !s.Equals("")).ToList();

            var result = new List<Result>();
            foreach (var baseUnitMap in BaseUnitMaps)
            {
                if (Regex.Match(query.RawQuery, "([0-9]+[" + baseUnitMap.GetUnitNamers() + "]{1}[ ]?)?|([-+*/]{1})?")
                         .Success)
                {
                    result.AddRange(UnitResolvers[baseUnitMap.GetBaseUnit().Unit].Resolve(query, operators, values));
                }
            }

            return result;
        }


        public List<BaseUnitMap> BaseUnitMaps = new List<BaseUnitMap>
        {
            TemperatureResolver.BaseUnitMap,
            LengthResolver.BaseUnitMap,
            TimeResolver.BaseUnitMap
        };

        public Dictionary<Type, IUnitResolver> UnitResolvers = new Dictionary<Type, IUnitResolver>
        {
            {typeof(Kelvin), new TemperatureResolver()},
            {typeof(Metre), new LengthResolver()},
            {typeof(Second), new TimeResolver()}
        };
    }
}
