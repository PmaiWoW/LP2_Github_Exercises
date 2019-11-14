using System;

namespace _02_ex02
{
    class Program
    {
        static void Main(string[] args)
        {
            Squad squad1 = new Squad(
                new Unit("Lancer", new Vector2(1f, 1f), 100f),
                new Unit("Assassin", new Vector2(1f, 2f), 80f), 
                new Unit("Caster", new Vector2(1f, 3f), 90f));

            Squad squad2 = new Squad(
                new Unit("Saber", new Vector2(2f, 1f), 150f), 
                new Unit("Ruler", new Vector2(2f, 2f), 200f), 
                new Unit("Rider", new Vector2(2f, 3f), 140f), 
                new Unit("Archer", new Vector2(2f, 4f), 110f), 
                new Unit("Berserker", new Vector2(2f, 5f), 170f));

            foreach(IUnit u in squad1.UntLst) Console.WriteLine(u);
            foreach(IUnit u in squad2.UntLst) Console.WriteLine(u);

            Console.WriteLine($"Squad1 center position: " +
                $"{squad1.Position.X}, {squad1.Position.Y}");

            Console.WriteLine($"Squad2 center position: " +
                $"{squad2.Position.X}, {squad2.Position.Y}");

            squad1.Move(new Vector2(5f, 5f));
            squad2.Move(new Vector2(5f, 5f));

            foreach (IUnit u in squad1.UntLst) Console.WriteLine(u);
            foreach (IUnit u in squad2.UntLst) Console.WriteLine(u);
        }
    }
}
