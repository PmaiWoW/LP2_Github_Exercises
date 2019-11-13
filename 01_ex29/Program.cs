using System;
using System.Collections.Generic;

namespace _01_ex29
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedSet<int> operationSet = new SortedSet<int>();
            HashSet<int> firstSet = new HashSet<int>();
            HashSet<int> secondSet = new HashSet<int>();
            string valueString = default;

            while (valueString != "q" && valueString != "")
            {
                TryInsert(out valueString, firstSet, "first set");
            }
            valueString = default;

            while (valueString != "q" && valueString != "")
            {
                TryInsert(out valueString, secondSet, "second set");
            }

            // Operations
            // Operation 1 - Union
            CopyFirstSetToOperationSet(firstSet, operationSet);
            Console.WriteLine("\nUnion of first set with second set:");
            operationSet.UnionWith(secondSet);
            foreach (int i in operationSet) Console.WriteLine(i);

            // Operation 2 - Intersection
            CopyFirstSetToOperationSet(firstSet, operationSet);
            Console.WriteLine("\nIntersection of first set with second set:");
            operationSet.IntersectWith(secondSet);
            foreach (int i in operationSet) Console.WriteLine(i);

            // Operation 3 - Difference
            CopyFirstSetToOperationSet(firstSet, operationSet);
            Console.WriteLine("\nDifference of first set and second set:");
            operationSet.ExceptWith(secondSet);
            foreach (int i in operationSet) Console.WriteLine(i);

            // Operation 4 - Symmetric Difference
            CopyFirstSetToOperationSet(firstSet, operationSet);
            Console.WriteLine("\nSymmetric Difference of first set and " +
                "second set:");
            operationSet.SymmetricExceptWith(secondSet);
            foreach (int i in operationSet) Console.WriteLine(i);

            // Operation 5 - Subset
            CopyFirstSetToOperationSet(firstSet, operationSet);
            if (operationSet.IsSubsetOf(secondSet))
            {
                Console.WriteLine("\nFirst set is a Subset of second set");
            }
            else Console.WriteLine("\nFirst set isn't a Subset of second set");

            // Operation 6 - Superset
            CopyFirstSetToOperationSet(firstSet, operationSet);
            if (operationSet.IsSupersetOf(secondSet))
            {
                Console.WriteLine("\nFirst set is a Superset of second set");
            }
            else Console.WriteLine("\nFirst set isn't a Superset of second " +
                "set");
        }

        private static SortedSet<int> CopyFirstSetToOperationSet(HashSet<int> 
            fSet, SortedSet<int> oSet)
        {
            oSet.Clear();
            foreach (int i in fSet) oSet.Add(i);
            return oSet;
        }

        private static void TryInsert(out string s, HashSet<int> set, string n)
        {
            Console.WriteLine($"Insert int value for {n}" +
                    $"(Q or enter nothing to stop insertion):");
            s = Console.ReadLine();

            if (s.ToLower() != "q" && s != "")
            {
                if (Int32.TryParse(s, out int val))
                {
                    set.Add(val);
                }
                else { Console.WriteLine("Value inserted is invalid."); }
            }
        }
    }
}