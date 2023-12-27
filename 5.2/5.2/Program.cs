using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string text;
            text = Console.ReadLine();
            text = Reverse(text);
            Console.Write(text);
            Console.ReadKey();

        }

        static string[] SplitText(string text)
        {
            return text.Split(' ');
        }

        static string Reverse(string text)
        {
            string[] words;
            string Rtext = "";
            words = SplitText(text);
            for(int i = 0; i < words.Length/2; i++)
            {
                string s;
                s = words[i];
                words[i] = words[words.Length - i - 1];
                words[words.Length - i - 1] = s;
            }
            for (int i = 0; i < words.Length; i++)
                Rtext += (words[i] + " ");
            return Rtext;
        }
    }
}
