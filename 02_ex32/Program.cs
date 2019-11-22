using System;
using System.Collections.Generic;

namespace _02_ex32
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Monster?> monsters = new List<Monster?>();
            monsters?.Add(null);
            monsters?.Add(Monster.Minion);

            Monster? monst = monsters?[0] ?? Monster.Minion;
            // Monster? monst = monsters[0].HasValue ? 
            //     monsters[0].Value : Monster.Minion;

            Console.WriteLine(monst);
        }
    }
}
