using System;
using System.Linq;

namespace _02_ex31
{
    class Program
    {
        private static NPC[] npcs = new NPC[3]
        {
            new NPC(new Item(ItemCategory.Weapon)),
            new NPC(new Item(ItemCategory.Cosmetic)),
            new NPC(new Item(ItemCategory.Healing))
        };

        static void Main(string[] args)
        {
            Program prog = new Program();

            for (int i = 0; i < npcs.Length; i++)
            {
                Console.WriteLine(prog.HasWeapons(i));
            }
        }

        // public bool HasWeapons(int npcId)
        // {
        //     return npcs[npcId].Bag.Any(item => item.Category == 
        //     ItemCategory.Weapon);
        // }

        public bool HasWeapons(int npcID) =>
            npcs?[npcID]?.Bag?.Any(item => item.Category == 
            ItemCategory.Weapon) ?? false;

        // int x = i ?? 0;

    }
}
