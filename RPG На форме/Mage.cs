using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    [Serializable()]
    class Mage : Hero
    {
        public Mage(string Name)
        {
            base.HP = 40;
            name = Name;
            strong = 65;
        }
        public override void Attack(Hero h1)
        {
            Random rnd = new Random();
            dmg = rnd.Next(55, 70);
            h1.HP -= dmg;
        }
    }
}
