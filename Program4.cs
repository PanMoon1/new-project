using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int min = int.MaxValue;
            int n;
            Console.WriteLine("Введите длину последовательности");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите числа");
            for (int i = 0; i < n; i++)
            {
                int k = int.Parse(Console.ReadLine());
                if (k < min) min = k;
            }
            Console.WriteLine("Минимальное число  " + min);
            Console.ReadKey();
        }
    }
}
