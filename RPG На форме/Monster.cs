using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    [Serializable()]
    class Monster : Hero
    {
        public override void Attack(Hero h1)
        {
            Random rnd = new Random();
            dmg = rnd.Next(20, 70);
            h1.HP -= dmg;
        }

        public Monster(string Name)
        {
            base.HP = 200;
            name = Name;
        }
    }
}
