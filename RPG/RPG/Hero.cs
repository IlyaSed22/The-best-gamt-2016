using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public class Hero
    {
        public double HP;
        public virtual void Attack(Hero h1)
        {
            
        }
        public double dmg;
        public int cd = 0;
        public int during = 2;
    }
}


