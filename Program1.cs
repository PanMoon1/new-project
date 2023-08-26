using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("Введите число");
            number = int.Parse(Console.ReadLine());
            if (number % 2 == 0) Console.WriteLine("Число четное");
            else Console.WriteLine("Число нечетное");
            Console.ReadKey();
        }
    }
}
