using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, sum;
            Random r = new Random();
            Console.WriteLine("Введите количество строк");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество столбцов");
            b = int.Parse(Console.ReadLine());
            int[,] m = new int[a, b];
            sum = 0;
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    m[i, j] = r.Next(0, 9);
                    Console.Write("  " + m[i, j]);
                    sum += m[i, j];
                }
                Console.WriteLine();
            }
            Console.WriteLine("Сумма всех элементов   " + sum);
            Console.ReadKey();
        }
    }
}
