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

        int IComparable<Weapon>.CompareTo(Weapon w2)
            => Convert.ToInt32(w2.AttackPower - AttackPower);

        public override string ToString() => $"Attack Power: {AttackPower}" +
            $"\nDurability: {Durability}";
    }
}
