using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program2
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Artem Matrokhin";
            string email = "artem.matrokhin@gmail.com";
            int age = 22;
            float programs = 89.9f;
            float maths = 85.2f;
            float physics = 96.6f;
            float mean;
            float sum;
            sum = programs + physics + maths;
            mean = sum / 3;
            Console.WriteLine("Name:  " + name);
            Console.WriteLine("Email:  " + email);
            Console.WriteLine("Age:  " + age);
            Console.WriteLine("Programs:  " + programs);
            Console.WriteLine("Maths:  " + maths);
            Console.WriteLine("Physics:  " + physics);
            Console.WriteLine("Sum:  " + sum);
            Console.WriteLine("Mean:  " + mean);
            Console.ReadKey();
        }
    }
}
