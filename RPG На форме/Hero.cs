using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    [Serializable()]
    public class Hero
    {
        public int strong;
        public string idname;
        public string name;
        public int HP;
        public int dmg;
        public virtual void Attack(Hero h1)
        {
           
        }
        public override string ToString()
        {
            return name;
        }
    }
}


