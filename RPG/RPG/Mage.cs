using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Mage : Hero
    {
        
        public Mage()
        {
            base.HP = 40;
        }
        public override void Attack(Hero h1)
        {
            Random rnd = new Random();
            dmg = rnd.Next(55, 70);
            h1.HP -= dmg;
        }
        public void PlusAttack(Hero h1)
        {
            if (cd == 0)
            {
                h1.dmg *= 1.5;
                cd += 2;
                MinusAttack(h1);
            }
            
        }
        public void MinusAttack(Hero h1)
        {
            during--;
            if(during == 0)
            {
                h1.dmg /= 1.5;
            }
        }
    }
}
