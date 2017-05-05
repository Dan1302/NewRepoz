using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            {
                Console.WriteLine("Как тебя зовут?");
                name = Console.ReadLine();
            }
            int age;
            {
                Console.WriteLine("Cколько тебе лет?");
                age = Convert.ToInt32(Console.ReadLine());
            }
            int x;
            x = 2009 - age;
            Console.WriteLine(name + " родился в " + x + " году");
            x = Convert.ToInt32(Console.ReadLine());
        }
    }
}
