using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public class Hero
    {
        public List<Hero> Heroes = new List<Hero>
        public bool HaveBaff;
        public virtual void Attack(Hero h1)
        {
            
        }
        public double dmg;
        public int cd = 0;
        public int during = 3;
        private double _hp;
        public double HP
        {
            get
            {
                return _hp;
            }
            set
            {
                if (value < 0)
                    _hp = 0;
                else
                {
                    _hp = value;
                }
            }
        }
        public void MinusAttack(Hero h1)
        {
            h1.dmg /= 1.5;
        }
    }

}


