namespace Jelmergu.Flow.Plugin.UnitConverter
{
    public interface IUnit<T>
    {
        public decimal Value {get;}

        public T ToBase();


    }
}
