using System;

namespace _01_ex22
{
    class Program
    {
        static void Main(string[] args)
        {
            GameItem sword1 = new Sword("Mythril Rapier", "A finely made " +
                "Mythril Rapier.", 110, TypeOfMetal.Mythril, 
                WeaponCondition.Sharpened);
        }
    }
}