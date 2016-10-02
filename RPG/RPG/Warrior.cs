using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Warrior : Hero
    {
        string name;
        int id;
        public Warrior()
        {
            base.HP = 150;
        }
        public override void Attack(Hero h1)
        {
            Random rnd = new Random();
            int dmg = rnd.Next(35, 40);
            h1.HP -= dmg;
        }
    }
}
