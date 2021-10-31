using System;
using System.Linq;
using Jelmergu.Flow.Plugin.MultiunitCalculator;

namespace Jelmergu.Flow.Plugin.UnitConverter
{
    public interface BaseUnitMap
    {
        public String GetUnitNamers();

        public UnitNamer GetBaseUnit();
    }

    public struct BaseUnitMap<TBase, T> : BaseUnitMap where TBase : IBaseUnit where T : IUnit<TBase>
    {
        public UnitNamer<TBase>      BaseUnit;
        public UnitNamer<T>[] Units;

        public BaseUnitMap(UnitNamer<TBase> baseUnit, params UnitNamer<T>[] units)
        {
            BaseUnit = baseUnit;
            Units    = units;
        }

        public String GetUnitNamers()
        {
            return Units.Select(unit => unit.Identifier).ToString();
        }

        public UnitNamer GetBaseUnit()
        {
            return BaseUnit;
        }
    }

    public interface UnitNamer
    {
        public string Identifier { get;}
        public Type   Unit       { get;}

    }

    public struct UnitNamer<T> : UnitNamer
    {
        public string Identifier { get; }
        public Type   Unit       { get; }

        public UnitNamer(string identifier, Type unit)
        {
            if (unit.IsInstanceOfType(typeof(T))) throw new Exception("TypeMismatch: " + unit + " does not match " + typeof(T));

            Identifier = identifier;
            Unit       = unit;
        }
    }
}
