using System.Collections.Generic;
using Flow.Launcher.Plugin;

namespace Jelmergu.Flow.Plugin.UnitConverter
{
    public class UnitConverter : IPlugin
    {
        private PluginInitContext _context;

        public void Init(PluginInitContext context)
        {
            _context = context;
        }

        public List<Result> Query(Query query)
        {
            return ProcessQuery(query);
        }

        private List<Result> ProcessQuery(Query query)
        {
            var rf = new ResolverFactory();
            return rf.IsResolvable(query) ? rf.Resolve(query) : new List<Result>();
        }
    }
}
