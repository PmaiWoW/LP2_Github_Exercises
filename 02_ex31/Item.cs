using System;
using System.Collections.Generic;
using System.Text;

namespace _02_ex31
{
    class Item
    {
        private ItemCategory category;
        public ItemCategory Category => category;

        public Item(ItemCategory catg)
        {
            category = catg;
        }
    }
}
