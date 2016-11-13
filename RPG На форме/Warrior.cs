using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    [Serializable()]
    class Warrior : Hero
    {
        int id;
        public Warrior(string NAme)
        {
            base.HP = 150;
            name = NAme;
            strong = 40;
        }
        public override void Attack(Hero h1)
        {
            Random rnd = new Random();
            dmg = rnd.Next(35, 40);
            h1.HP -= dmg;
        }
    }
}
