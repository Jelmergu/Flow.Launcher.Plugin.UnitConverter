using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using Flow.Launcher.Plugin;

namespace Jelmergu.Flow.Plugin.UnitConverter.Resolvers
{
    public abstract class UnitResolver<TBase, TUnit>: IUnitResolver where TBase : IBaseUnit where TUnit : IUnit<TBase>
    {
        public List<Result> Resolve(Query query, List<string> operators, List<string> values)
        {
            try
            {
                var valuesSplit =
                    values.Select(v =>
                            new List<string>
                            {
                                new Regex("[^0-9]+").Split(query.Search)[0],
                                new Regex("[0-9]+").Split(query.Search)[1]
                            })
                        .Select(MapToUnit)
                        .Select(t => t.ToBase())
                        .ToList();

                var result = new Sum();
                var valueEnumerator = valuesSplit.GetEnumerator();
                var operatorEnumerator = operators.GetEnumerator();
                while (valueEnumerator.MoveNext())
                {
                    operatorEnumerator.MoveNext();
                    result.Apply(valueEnumerator.Current.Value, operatorEnumerator.Current);
                }

                return CreateResult(result.GetResult());
            }
            catch (NullReferenceException)
            {
                return new List<Result>();
            }
            catch (IndexOutOfRangeException)
            {
                return new List<Result>();
            }
        }

        public abstract List<Result> CreateResult(decimal value);

        public TUnit MapToUnit(List<string> values) => MapToUnit(values[0], values[1]);

        public abstract TUnit MapToUnit(string value, string unit);
    }
}
