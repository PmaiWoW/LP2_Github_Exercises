using System;
using System.Collections.Generic;
using System.Linq;

namespace _02_ex33
{
    class Program
    {
        static void Main(string[] args)
        {
            // Código de teste, em que se verifica que o novo valor default
            // de um Nullable<int> é null e não 0:
            int? a = default;
            Console.WriteLine($"boi: {a.HasValue}");

            // Alínea 2:
            // Resultado da seguinte linha de código (apenas o que está dentro
            // do Console.WriteLine();
            Console.WriteLine(8.IsDivisiorOf(15));

            Console.WriteLine();

            // Alínea 3:
            IEnumerable<int> setOfInts = new HashSet<int>()
            {
                1, 4, 6, 7, 8, 9, 12, 17, 29, 36
            };

            int EvenIntsCount =
                (from integer in setOfInts
                where integer.IsEven()
                select integer).Count();

            Console.WriteLine(EvenIntsCount);

            Console.WriteLine();

            IEnumerable<int> divisorsOf60 =
                from integer in setOfInts
                where integer.IsDivisiorOf(60)
                select integer;

            for (int i = 0; i < divisorsOf60.Count(); i++) 
                Console.WriteLine(divisorsOf60.ElementAt(i));

            Console.WriteLine();

            // Alínea 4:
            IEnumerable<int?> setOfIntsOrNulls = new HashSet<int?>()
            {
                1, null, 2, null, 6, null, 12, 50
            };

            // Alínea 5:
            bool containsNulls =
                (from integer in setOfIntsOrNulls
                where !integer.HasValue
                select integer).Any();
            Console.WriteLine(containsNulls);

            Console.WriteLine();


            //Alínea 6:
            int xored = default;

            foreach(int? i in setOfIntsOrNulls)
            {
                int x = i ?? 0;
                xored ^= x;
            }

            Console.WriteLine(xored);
            Console.WriteLine();

            // for(int i = 0; i < setOfIntsOrNulls.Count(); i++)
            // {
            //     int? x = setOfIntsOrNulls?.ElementAt(i) ?? default;
            //     Console.WriteLine(x ^= xored);
            // }
        }
        
    }
}
