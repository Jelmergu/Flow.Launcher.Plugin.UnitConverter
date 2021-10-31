namespace Jelmergu.Flow.Plugin.UnitConverter.Length
{
    public abstract class Length : IUnit<Metre>
    {
        public decimal SIFactor;

        public decimal Value { get; }

        public Length(decimal length)
        {
            Value = length;
        }

        public virtual Metre ToBase()
        {
            return new Metre(Value / SIFactor);
        }
    }
}
