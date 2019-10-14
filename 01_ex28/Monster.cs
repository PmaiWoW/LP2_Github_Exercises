using System;
using System.Collections.Generic;
using System.Text;

namespace _01_ex28
{
    class Monster
    {
        public const double MaxHealth = 100;
        public const int MaxStrength = 200;
        public MonsterType Type { get; set; }
        public double Health { get; set; }
        public int Strength { get; set; }

        public Monster(MonsterType type, double health, int strength)
        {
            Type = type;
            Health = health;
            Strength = strength;

        }

        public static IEnumerable<Monster> CreateRandomMonsters(int n)
        {
            Random rnd;
            List<Monster> monsEnumerable = new List<Monster>();
            for (int i = 0; i <= n; i++)
            {
                rnd = new Random();
                monsEnumerable.Add(new Monster(
                    (MonsterType)rnd.Next(0, 3), rnd.NextDouble()*100,
                    rnd.Next(0, MaxStrength)));
            }
            return monsEnumerable;
        }

        public override string ToString() => $"Type: {Type}, " +
            $"Health: {Health:f2}, Strength: {Strength:d}";
    }

    
}
