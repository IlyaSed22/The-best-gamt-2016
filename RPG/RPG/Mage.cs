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
            int dmg = rnd.Next(55, 70);
            h1.HP -= dmg;
        }
    }
}
