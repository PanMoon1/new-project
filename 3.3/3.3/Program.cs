using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 2;
            int n;
            Console.WriteLine("Введите число");
            n = int.Parse(Console.ReadLine());
            bool prost = false;
            while (i < n)
            {
                if (n % i == 0) prost = true;
                i++;
            }
            if (prost)
                Console.WriteLine("Ваше число не простое");
            else
                Console.WriteLine("Ваше число простое");
            Console.ReadKey();
        }
    }
}
