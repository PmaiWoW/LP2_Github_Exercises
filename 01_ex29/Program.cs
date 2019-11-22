using System;
using System.Collections.Generic;

namespace _01_ex29
{
    class Program
    {
        static void Main(string[] args)
        {
            ISet<int> operationSet = new SortedSet<int>();
            ICollection<int> firstSet = new HashSet<int>();
            ICollection<int> secondSet = new HashSet<int>();
            string valueString = default;

            InsertValues(valueString, firstSet);
            InsertValues(valueString, secondSet);

            // Operations
            // Operation 1 - Union
            ResetOperationSet(firstSet, operationSet);

            Console.WriteLine("\nUnion of first set with second set:");
            operationSet.UnionWith(secondSet);
            foreach (int i in operationSet) Console.WriteLine(i);

            // Operation 2 - Intersection
            ResetOperationSet(firstSet, operationSet);

            Console.WriteLine("\nIntersection of first set with second set:");
            operationSet.IntersectWith(secondSet);
            foreach (int i in operationSet) Console.WriteLine(i);

            // Operation 3 - Difference
            ResetOperationSet(firstSet, operationSet);

            Console.WriteLine("\nDifference of first set and second set:");
            operationSet.ExceptWith(secondSet);
            foreach (int i in operationSet) Console.WriteLine(i);

            // Operation 4 - Symmetric Difference
            ResetOperationSet(firstSet, operationSet);

            Console.WriteLine("\nSymmetric Difference of first set and " +
                "second set:");
            operationSet.SymmetricExceptWith(secondSet);
            foreach (int i in operationSet) Console.WriteLine(i);

            // Operation 5 - Subset
            ResetOperationSet(firstSet, operationSet);
            if (operationSet.IsSubsetOf(secondSet))
            {
                Console.WriteLine("\nFirst set is a Subset of second set");
            }
            else Console.WriteLine("\nFirst set isn't a Subset of second set");

            // Operation 6 - Superset
            ResetOperationSet(firstSet, operationSet);
            if (operationSet.IsSupersetOf(secondSet))
            {
                Console.WriteLine("\nFirst set is a Superset of second set");
            }
            else Console.WriteLine("\nFirst set isn't a Superset of second " +
                "set");
        }

        private static ICollection<int> ResetOperationSet(
            ICollection<int> fSet, ICollection<int> oSet)
        {
            oSet.Clear();
            foreach (int i in fSet) oSet.Add(i);
            return oSet;
        }

        private static void InsertValues(string s, ICollection<int> collection)
        {
            Console.WriteLine("Insert int values for set (Enter Q or " +
                "nothing to stop insertion):");

            while (s != "q" && s != "")
            {
                s = Console.ReadLine();

                if (s.ToLower() != "q" && s != "")
                {
                    if (Int32.TryParse(s, out int val))
                    {
                        collection.Add(val);
                    }
                    else { Console.WriteLine("Value inserted is invalid."); }
                }
            }
            Console.WriteLine("Set insertion complete.\n");
        }
    }
}