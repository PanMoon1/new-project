using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Random r = new Random();
            Console.WriteLine("Введите количество строк");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество столбцов");
            b = int.Parse(Console.ReadLine());
            int[,] m = new int[a, b];
            int[,] n = new int[a, b];
            int[,] l = new int[a, b];
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    m[i, j] = r.Next(0, 4);
                    Console.Write("  " + m[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    n[i, j] = r.Next(0, 4);
                    Console.Write("  " + n[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    l[i, j] = m[i, j] + n[i, j];
                    Console.Write("  " + l[i, j]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
