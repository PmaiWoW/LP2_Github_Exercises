using System;

namespace _01_ex22
{
    class Program
    {
        static void Main(string[] args)
        {
            Sword sword1 = new Sword("Mythril Rapier", "A finely made " +
                "Mythril Rapier.", 110, TypeOfMetal.Mythril,
                WeaponCondition.Sharpened);

            Console.WriteLine($"{sword1.name}\nDescription: " +
                $"{sword1.description}\nLength(cm): {sword1.length}\n" +
                $"Metal Type: {sword1.typeOfMetal}\nCondition: " +
                $"{sword1.condition}");
        }
    }
}