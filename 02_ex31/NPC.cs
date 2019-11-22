using System;
using System.Collections.Generic;
using System.Text;

namespace _02_ex31
{
    class NPC
    {
        private ICollection<Item> bag;

        public ICollection<Item> Bag => bag;

        public NPC(Item item)
        {
            bag = new HashSet<Item>() { item };
        }
    }
}
