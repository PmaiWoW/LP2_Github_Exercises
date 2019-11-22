using System;
using System.Linq;

namespace _02_ex31
{
    class Program
    {
        static Item item1 = new Item(ItemCategory.Weapon);
        static Item item2 = new Item(ItemCategory.Cosmetic);
        static Item item3 = new Item(ItemCategory.Healing);
        //    new NPC(new Item(ItemCategory.Junk));
        //    new NPC(new Item(ItemCategory.Sellable)),
        //    new NPC(new Item(ItemCategory.Weapon)),
        //    new NPC(new Item(ItemCategory.Junk)),
        //    new NPC(null),
        //    new NPC(new Item(ItemCategory.Junk)),
        //    new NPC(new Item(ItemCategory.Cosmetic))

        static NPC[] npcs = new NPC[3]
        {
            new NPC(item1),
            new NPC(item2),
            new NPC(item3)
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
