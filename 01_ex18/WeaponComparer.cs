using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace _01_ex18
{
    public class WeaponComparer : IComparer<Weapon>
    {
        public int Compare(Weapon w1, Weapon w2)
        {
            if (ReferenceEquals(w1, w2)) return 0;
            if (w1 == null) return -1;
            if (w2 == null) return 1;
            if (w1.Durability - w2.Durability > 0) return 1;
            if (w1.Durability - w2.Durability < 0) return -1;
            return 0;
        }
    }
}
