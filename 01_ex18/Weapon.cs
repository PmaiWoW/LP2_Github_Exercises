using System;
using System.Collections.Generic;
using System.Text;

namespace _01_ex18
{
    public class Weapon : IComparable<Weapon>
    {
        public float AttackPower { get; }
        public float Durability { get; }

        public Weapon(float attackPower, float durability)
        {
            AttackPower = attackPower;
            Durability = durability;
        }

        public int CompareTo(Weapon w2)
        {
            if (w2 == null) return 1;
            if (w2.AttackPower - AttackPower > 0) return 1;
            if (w2.AttackPower - AttackPower < 0) return -1;
            return 0;
        }

        public override string ToString() => $"Attack Power: {AttackPower}" +
            $"\tDurability: {Durability}";
    }
}
