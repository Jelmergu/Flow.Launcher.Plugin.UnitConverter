namespace Jelmergu.Flow.Plugin.UnitConverter
{
    public class Sum
    {
        private decimal? _decimal;
        private string  _op;

        public void Apply(decimal d)
        {
            _decimal = ResolveOperator(d);
            _op      = null;
        }

        public void Apply(decimal d, string op)
        {
            _decimal = ResolveOperator(d);
            _op      = op;
        }

        public decimal GetResult()
        {
            return _decimal ?? default;
        }

        private decimal ResolveOperator(decimal d)
        {
            if (_decimal == null)
            {
                return d;
            }
            if (_op == null)
                return (decimal) _decimal;

            switch (_op)
            {
                default:
                    return (decimal) (_decimal + d);
                case "-":
                    return (decimal) (_decimal - d);
                case "/":
                    return (decimal) (_decimal / d);
                case "*":
                    return (decimal) (_decimal * d);
            }
        }
    }
}
