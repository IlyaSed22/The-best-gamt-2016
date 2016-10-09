using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class GameLogical 
    {
        int NumOfTurn;
        static public void MinusBaff(List<Hero> list)
        {
            foreach (Hero h in list)
            {
                if (h.HaveBaff == true)
                {
                    if(h.during > 0)
                        h.during--;
                    if (h.during == 0)
                    {
                        h.HaveBaff = false;
                        
                    }
                }
            }
        }
    }
}
