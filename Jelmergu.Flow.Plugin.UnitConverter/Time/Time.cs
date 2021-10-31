namespace Jelmergu.Flow.Plugin.UnitConverter.Time
{
    public abstract class Time : IUnit<Second>
    {
        public decimal Value { get; }

        public Time(decimal time)
        {
            Value = time;
        }

        public abstract Second ToBase();

        public static Time operator +(Time a, Time b) => new Second(((Time) a.ToBase()).Value + ((Time) b.ToBase()).Value);

        public static Time operator -(Time a, Time b) => new Second(((Time) a.ToBase()).Value - ((Time) b.ToBase()).Value);
    }
}
