using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            Console.WriteLine("What is your name?");

            string name;
            name = Console.ReadLine();

            Console.WriteLine("Hello " + name + "! \nPlease enter an integer between 1 and 100.");

            int input;
            input = int.Parse(Console.ReadLine());

            if ( input % 2 == 0)
            {

            }
        }
    }
}
