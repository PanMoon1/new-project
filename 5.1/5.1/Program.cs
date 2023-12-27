using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string text;
            string[] words;
            text = Console.ReadLine();
            words = SplitText(text);
            Show(words);
            Console.ReadKey();

        }

        static string[] SplitText(string text)
        {
            return text.Split(' ');
        }

        static void Show(string[] words)
        {
            foreach(string s in words)
            {
                Console.WriteLine(s);
            }
        }
    }
}
