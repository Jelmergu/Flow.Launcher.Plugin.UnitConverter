using Flow.Launcher.Plugin;

namespace Jelmergu.Flow.Plugin.UnitConverter.Test.Resolvers
{
    public abstract class ResolverTest
    {
        protected Query CreateQuery(string input)
        {
            return new Query(input, input, input.Split(" "));
        }

    }
}
