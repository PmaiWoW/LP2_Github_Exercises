using System;
using System.Collections.Generic;
using System.Text;

namespace _02_ex26
{
    public class Gun : Weapon
    {
        private Bullet[] bullets;

        Func<int, float, Bullet[], Bullet[]> newClip =(numBuls, cal, buls) =>
        {
            for (int i = 0; i < numBuls; i++) 
                buls[i] = new Bullet() { Calibre = cal };
            return buls;
        };

        public Gun(float value, int numBullets, float calibre) : base(value)
        {
            newClip(numBullets, calibre, bullets);
        }
    }
}
