using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            int sum = 0;
            Console.WriteLine("Приветствую! Сколько у Вас карт на руках?");
            num = int.Parse(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("Введите номинал следующей карты");
                switch (Console.ReadLine())
                {
                    case "J": sum += 10; break;
                    case "Q": sum += 10; break;
                    case "K": sum += 10; break;
                    case "T": sum += 10; break;
                    case "6": sum += 6; break;
                    case "7": sum += 7; break;
                    case "8": sum += 8; break;
                    case "9": sum += 9; break;
                    case "10": sum += 10; break;
                }
            }
            Console.WriteLine("Ваша сумма:  " + sum);
            Console.ReadKey();
        }
    }
}
