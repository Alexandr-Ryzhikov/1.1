using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            double r=20;
            Console.WriteLine("Введите внешний радиус (Больше 20): ");
            Console.WriteLine("Площадь кольца S={0}", Math.PI * (Math.Pow(Convert.ToDouble(Console.ReadLine()), 2) - Math.Pow(r, 2)));
            Console.ReadKey();
        }
    }
}
