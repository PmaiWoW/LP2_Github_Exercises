using System;
using System.Collections.Generic;
using System.Text;

namespace _01_ex22
{
    class Sword : GameItem
    {
        private decimal length;
        private TypeOfMetal typeOfMetal;
        private WeaponCondition condition;
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
