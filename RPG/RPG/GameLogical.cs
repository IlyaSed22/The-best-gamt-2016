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
        public void start()
        {
            for (int ikk = 0; ikk < 3; ikk++)
            {
                Console.WriteLine("Выбери персонажа");
                Console.WriteLine("1) Воин");
                Console.WriteLine("2) Жрец");
                Console.WriteLine("3) Маг");
                int jjjjj = int.Parse(Console.ReadLine());
                switch (jjjjj)
                {
                    case 1:

                        break;
                }
            }
        }
    }
}
