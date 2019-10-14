using System;

namespace _01_ex20
{
    class Program
    {
        static void Main(string[] args)
        {
            Enemy monster = new Enemy(100);

            Console.WriteLine($"{monster.Health}");
            Console.WriteLine($"{Enemy.NumberOfEnemies}");
        }
    }
}
