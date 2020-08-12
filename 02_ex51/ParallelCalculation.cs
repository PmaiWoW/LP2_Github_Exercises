using System;
using System.Collections.Generic;
using System.Text;

namespace _02_ex51
{
    public class ParallelCalculation
    {
        private object resultLock = new object();
        private double result;

        public void AddToResult(double toAdd)
        {
            lock (resultLock)
            {
                result += toAdd;
            }
        }

        // Other code

        public event Action Bingo;

        private void OnBingo()
        {
            Bingo?.Invoke();
        }
    }
}
