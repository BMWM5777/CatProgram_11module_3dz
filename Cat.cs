using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatProgram
{
    public class Cat
    {
        private int eatlvl;

        public int EatLvl
        {
            get { return eatlvl; }
        }

        public void EatEnything(Eat EatView)
        {
            switch (EatView)
            {
                case Eat.Молоко:
                    eatlvl += 8;
                    Console.WriteLine("Кошка попила молока и теперь ее уровень сытости: " + eatlvl);
                    break;

                case Eat.Рыба:
                    eatlvl += 10;
                    Console.WriteLine("Кошка поела рыбу и теперь ее уровень сытости: " + eatlvl);
                    break;

                case Eat.Мышь:
                    eatlvl += 5;
                    Console.WriteLine("Кошка поймала мышь и теперь ее уровень сытости: " + eatlvl);
                    break;

                case Eat.Корм:
                    eatlvl += 7;
                    Console.WriteLine("Кошка поела корм и теперь ее уровень сытости: " + eatlvl);
                    break;

                default:
                    Console.WriteLine("Такого вида еды кошка не ест.");
                    break;
            }
        }
    }
}
