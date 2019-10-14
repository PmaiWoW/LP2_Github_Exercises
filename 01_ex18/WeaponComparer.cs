using System;
using System.Collections.Generic;
using System.Text;

namespace _01_ex18
{
    public class WeaponComparer : IComparer<Weapon>
    {
        int IComparer<Weapon>.Compare(Weapon w1, Weapon w2)
            => Convert.ToInt32(w1.Durability - w2.Durability);
    }
}
