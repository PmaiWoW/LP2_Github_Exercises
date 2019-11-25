using System;
using System.Collections.Generic;
using System.Text;

namespace _02_ex26
{
    public struct Bullet
    {
        private float calibre;
        public float Calibre
        {
            get => calibre;
            set => calibre = value < 0.1f ? 0.1f : value;
        }
    }
}
