using System;
using System.Collections.Generic;

namespace _01_ex18
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Weapon> weaponsList = new List<Weapon>()
            {
                new Weapon(132.23f, 123.2f),
                new Weapon(50.5f, 23.5f),
                new Weapon(10.7f, 122.9f),
                new Weapon(102.34f, 235.4f),
                new Weapon(243.9f, 93.43f),
                new Weapon(150.7f, 57.32f),
                new Weapon(31.9f, 315.98f),
                new Weapon(92.4f, 78.12f)
            };
            WeaponComparer wpnComp = new WeaponComparer();

            Console.WriteLine("Unsorted List:");
            foreach(Weapon w in weaponsList) Console.WriteLine(w);

            weaponsList.Sort();

            Console.WriteLine("\nSorted List (AttackPower):");
            foreach (Weapon w in weaponsList) Console.WriteLine(w);

            weaponsList.Sort(wpnComp);

            Console.WriteLine("\nSorted List (Durability):");
            foreach (Weapon w in weaponsList) Console.WriteLine(w);
        }
    }
}
