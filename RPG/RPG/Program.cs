using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public static class GameLogical
    {
        //public static void Fight(Hero h1, Hero h2)
        //{
        //    switch (classOfPerson)
        //    {
        //        case "warrior":
        //            Warrior war = new Warrior();
        //            break;
        //        case "healer":
        //            Healer healer = new Healer();
        //            break;
        //    }
        //    switch (classOfEnemy)
        //    {
        //        case "monster":
        //            Monster monster = new Monster();
        //            break;
        //    }
        //}
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            Warrior WY = new Warrior();
            Healer HY = new Healer();
            Monster EM = new Monster();
            Mage MY = new Mage();
            while (x == 0)
            {
                //if (WY.HP <= 0)
                //{
                //    Console.WriteLine("Ваш воин погиб, а жрец долго не продержится( Попробуйте снова");
                //    x++;
                //    break;
                //}
                //if (WY.HP <= 0)
                //{
                //    Console.WriteLine("Ваш воин погиб, а жрец долго не продержится( Попробуйте снова");
                //    x++;
                //    break;
                //}
                if (EM.HP <= 0)
                {
                    Console.WriteLine("Ты победил монстра!");
                    x++;
                    break;
                }
                Console.WriteLine("Выберите перонажа:");
                if(WY.HP >= 0)
                    Console.WriteLine("1) Воин HP - " + WY.HP);
                if(HY.HP >= 0)
                    Console.WriteLine("2) Жрец HP - " + HY.HP);
                if (MY.HP >= 0)
                    Console.WriteLine("3) Маг HP - " + MY.HP);
                int a = int.Parse(Console.ReadLine());
                switch (a)
                {
                    case 1:
                        {
                            if (WY.HP >= 0)
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
                        if (HY.HP >= 0)
                        {
                            Console.WriteLine("Что вы хотите сделать?");
                            Console.WriteLine("1) Восстановить жизни союзнику");
                            Console.WriteLine("2) Ударить");
                            int HDo = int.Parse(Console.ReadLine());
                            if (HDo == 1)
                            {
                                HY.Heal(WY);
                                if (WY.HP > 150)
                                {
                                    WY.HP = 150;
                                }
                                Console.WriteLine("Ваши жизни Воина - " + WY.HP);
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
                            if (MY.HP >= 0)
                            {
                                MY.Attack(EM);
                                EM.Attack(MY);
                                Console.WriteLine("Вы атаковали монстра! Его жизни - " + EM.HP);
                                Console.WriteLine("Ваши жизни Мага - " + MY.HP);
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
    }
}