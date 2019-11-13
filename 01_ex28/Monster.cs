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

        // public Monster(MonsterType type, double health, int strength)
        // {
        //     Type = type;
        //     Health = health;
        //     Strength = strength;
        // }

        public static IEnumerable<Monster> CreateRandomMonsters(int n)
        {
            Random rnd = new Random();
            Monster returnMonster = new Monster();
            for (int i = 0; i < n; i++)
            {
                returnMonster.Type = (MonsterType)rnd.Next(0, 4);
                returnMonster.Health = rnd.NextDouble()*MaxHealth;
                returnMonster.Strength = rnd.Next(0, MaxStrength+1);
                yield return returnMonster;
            }
        }

        public override string ToString() => $"Type: {Type}, " +
            $"Health: {Health:f2}, Strength: {Strength:d}";
    }

    
}
