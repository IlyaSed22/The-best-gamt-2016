using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    [Serializable()]
    class Healer : Hero
    {
        
        public void Heal(Hero h1)
        {
            h1.HP = h1.HP + 50;
        }
        public void Attack(Hero h1)
        {
            Random rnd = new Random();
            dmg = rnd.Next(5, 20);
            h1.HP -= dmg;
        }
         public Healer(string NAMe)
        {
            base.HP = 75;
            Random rnd = new Random();
            dmg = rnd.Next(5, 20);
            name = NAMe;
            strong = 15;
        }
    } 
}
