using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Hero> Heros = new List<Hero>();
            int x = 0;
            Warrior WY = new Warrior();
            Healer HY = new Healer();
            Monster EM = new Monster();
            Mage MY = new Mage();
            Heros.Add(WY);
            Heros.Add(HY);
            Heros.Add(MY);
            while (x == 0)
            {
                GameLogical.MinusBaff(Heros);
                if(HY.cd > 0)
                HY.cd--;
                if(MY.cd > 0)
                MY.cd--;
                if (EM.HP <= 0)
                {
                    Console.WriteLine("Ты победил монстра!");
                    x++;
                    break;
                }
                Console.WriteLine("Выберите перонажа:");
                if(WY.HP > 0)
                    Console.WriteLine("1) Воин HP - " + WY.HP);
                if(HY.HP > 0)
                    Console.WriteLine("2) Жрец HP - " + HY.HP);
                if (MY.HP > 0)
                    Console.WriteLine("3) Маг HP - " + MY.HP + "  КД = " + MY.cd);
                int a = int.Parse(Console.ReadLine());
                switch (a)
                {
                    case 1:
                        {
                            if (WY.HP > 0)
                            {
                                WY.Attack(EM);
                                EM.Attack(WY);
                                Console.WriteLine("Вы атаковали монстра! Его жизни - " + EM.HP);
                                Console.WriteLine("Ваши жизни Воина - " + WY.HP);
                            }
                            else
                            {
                                Console.WriteLine("Ваш воин уже умер, так что все остальные ваши герои получают урон");
                                EM.Attack(HY);
                                EM.Attack(MY);
                            }
                        }
                        break;
                    case 2:
                        if (HY.HP > 0)
                        {
                            Console.WriteLine("Что вы хотите сделать?");
                            Console.WriteLine("1) Восстановить жизни союзнику");
                            Console.WriteLine("2) Ударить");
                            int HDo = int.Parse(Console.ReadLine());
                            if (HDo == 1)
                            {
                                if (HY.cd == 0)
                                {
                                    HY.cd += 2;
                                    Console.WriteLine("Кого лечить?");
                                    Console.WriteLine("1) Воин");
                                    Console.WriteLine("2) Маг");
                                    int babuin = int.Parse(Console.ReadLine());
                                    switch (babuin)
                                    {
                                        case 1:
                                            HY.Heal(WY);
                                            break;
                                        case 2:
                                            HY.Heal(MY);
                                            break;
                                    }
                                }
                            }
                            if (HDo == 2)
                            {
                                HY.Attack(EM);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Ваш жрец уже умер, так что все остальные ваши герои получают урон");
                            EM.Attack(WY);
                            EM.Attack(MY);
                        }
                        break;
                    case 3:
                        {
                            if (MY.HP != 0)
                            {
                                Console.WriteLine("Что вы хотите сделать?");
                                Console.WriteLine("1) Увеличить урон союзнику");
                                Console.WriteLine("2) Ударить");
                                int HDo = int.Parse(Console.ReadLine());
                                if (HDo == 1)
                                {
                                    if(MY.cd > 0)
                                    {
                                        Console.WriteLine("У вас кд. Вы получаете урон");
                                        EM.Attack(WY);
                                        EM.Attack(HY);
                                        EM.Attack(WY);
                                    }              
                                    if (MY.cd == 0)
                                    {
                                        Console.WriteLine("Кого баффать?");
                                        Console.WriteLine("1) Воин");
                                        Console.WriteLine("2) Жрец");
                                        int babuinchik = int.Parse(Console.ReadLine());
                                        switch (babuinchik)
                                        {
                                            case 1:
                                                MY.PlusAttack(WY);                                                
                                                break;
                                            case 2:
                                                MY.PlusAttack(HY);
                                                break;
                                        }
                                    }
                                                          
                                }
                                if (HDo == 2)
                                {
                                    MY.Attack(EM);
                                    Console.WriteLine("Вы атаковали монстра! Его жизни - " + EM.HP);
                                    Console.WriteLine("Ваши жизни Мага - " + MY.HP);
                                }
                            }
                            else
                            {
                                Console.WriteLine("Ваш маг уже умер, так что все остальные ваши герои получают урон");
                                EM.Attack(WY);
                                EM.Attack(HY);
                            }
                        }
                        break;
                }
            }
            
        }
        public void start()
        {
            for (int ikk = 0; ikk < 0; ikk++)
            {
                Console.WriteLine("Выбери персонажа");
                Console.WriteLine("1) Воин");
                Console.WriteLine("2) Жрец");
                Console.WriteLine("3) Маг");
                int jjjjj = int.Parse(Console.ReadLine());
                switch(jjjjj)
                {
                    case 1:
                        
                        break;
                }
            }
        }
    }
}