namespace Jelmergu.Flow.Plugin.UnitConverter.Temperatures
{
    public abstract class Temperature : IUnit<Kelvin>
    {
        public decimal Value { get;}

        public Temperature(decimal temp)
        {
            Value = temp;
        }



        public abstract Kelvin ToBase();

        public static Temperature operator +(Temperature a, Temperature b) => new Kelvin(((Temperature) a.ToBase()).Value + ((Temperature) b.ToBase()).Value);

        public static Temperature operator -(Temperature a, Temperature b) => new Kelvin(((Temperature) a.ToBase()).Value - ((Temperature) b.ToBase()).Value);
    }
}
