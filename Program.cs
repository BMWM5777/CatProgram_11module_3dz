using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatProgram
{
    class Program
    {
        static void Main()
        {
            Cat Murzik = new Cat();

            Murzik.EatEnything(Eat.Рыба);
            Murzik.EatEnything(Eat.Молоко);
            Murzik.EatEnything(Eat.Мышь);
            Murzik.EatEnything(Eat.Корм);
            Murzik.EatEnything((Eat)10); // Пример неверного вида еды

            Console.ReadKey();
        }
    }
}
