using System;
using System.Collections.Generic;
using System.Text;

namespace _01_ex22
{
    class Sword : GameItem
    {
        public readonly decimal length;
        public readonly TypeOfMetal typeOfMetal;
        public WeaponCondition condition;
        public Sword(string name, string description, decimal length,
            TypeOfMetal typeOfMetal, WeaponCondition condition) : base(name, 
                description)
        {
            this.length = length;
            this.typeOfMetal = typeOfMetal;
            this.condition = condition;
        }
    }
}
