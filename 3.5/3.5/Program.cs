using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int k = -1;
            string s;
            Console.WriteLine("Введите максимальное число");
            n = int.Parse(Console.ReadLine());
            Random rand = new Random();
            int number = rand.Next(0, n+1);
            while (k != number)
            {
                s = Console.ReadLine();
                if (s == "") break;
                k = int.Parse(s);
                if (k < number) Console.WriteLine("Ваше число меньше загаданного");
                else if (k > number) Console.WriteLine("Ваше число больше загаданного");
            }
            Console.WriteLine("Загаданное число  " + number);
            Console.ReadKey();
        }
    }
}
