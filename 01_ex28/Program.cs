using System;
using System.Collections.Generic;

namespace _01_ex28
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<Monster> monsEnumerable = 
                Monster.CreateRandomMonsters(20);
            foreach (Monster m in monsEnumerable) Console.WriteLine(m);
        }
    }
}
