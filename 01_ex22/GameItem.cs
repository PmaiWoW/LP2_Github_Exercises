using System;
using System.Collections.Generic;
using System.Text;

namespace _01_ex22
{
    public abstract class GameItem
    {
        public readonly string name;
        public readonly string description;

        public GameItem(string name, string description)
        {
            this.name = name;
            this.description = description;
        }
    }
}
