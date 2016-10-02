using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Monster : Hero
    {
        public override void Attack(Hero h1)
        {
            Random rnd = new Random();
            dmg = rnd.Next(20, 70);
            h1.HP -= dmg;
        }

        public Monster()
        {
            base.HP = 200;
        }
    }
}
