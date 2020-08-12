using System;

namespace _02_ex51
{
    class Program
    {

        static void Main(string[] args)
        {
            ParallelCalculation pc = new ParallelCalculation();

            pc.Bingo += BingoHandler;
        }

        private static void BingoHandler()
        {
            // BINGO
        }
    }
}
