using System;
using System.Collections.Generic;
using System.Text;

namespace _02_ex33
{
    public static class IntExtensions
    {
        // Alínea 1:
        public static bool IsEven(this int x) => x % 2 == 0;

        public static bool IsZeroOrPositive(this int x) => (x >= 0);

        public static bool IsDivisiorOf(this int x, int otherInt) =>
            otherInt % x == 0;
    }
}
