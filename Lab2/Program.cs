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

            Console.Clear();
            Console.WriteLine("Hello " + name + "! \nPlease enter an integer between 1 and 100.");

            int input;
            input = int.Parse(Console.ReadLine());
            
            if ( input % 2 == 0) //if statement for even numbers
            {
                if (input <= 25)
                {
                    Console.WriteLine("Thanks " + name + "! \nThat number is even and less than 25");
                }
                else if (input > 60)
                {
                    Console.WriteLine("Thanks " + name + "! \n" + input + " is even.");
                }
                else
                {
                    Console.WriteLine("Thanks " + name + "! \nThat number is even.");
                }
            }
            
            else if ( input % 2 == 1) //else statement for odd numbers
            {
                Console.WriteLine("Thanks " + name + "! \n" + input + " is odd.");
            }
            else //error?
            {
                Console.WriteLine("Input was invalid. Please enter an integer between 1 and 100.");
            }
        }
    }
}
