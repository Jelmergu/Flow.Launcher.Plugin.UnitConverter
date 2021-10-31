using System.Collections.Generic;
using Flow.Launcher.Plugin;

namespace Jelmergu.Flow.Plugin.UnitConverter
{
    public interface IUnitResolver
    {
        public List<Result> Resolve(Query query, List<string> operators, List<string> values);
    }
}
