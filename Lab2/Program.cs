using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

            bool run = true;
            int input;

            do
            {

                Console.Clear();
                Console.WriteLine("Hello " + name + "! \nPlease enter an integer between 1 and 100.");

                while(!int.TryParse(Console.ReadLine(), out input)) {

                    Console.WriteLine("Input was invalid " + name + ". Please enter an integer between 1 and 100.");
                }

                if (input % 2 == 0) //if statement for even numbers
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

                else if(input % 2 == 1) //else statement for odd numbers
                {
                    Console.WriteLine("Thanks " + name + "! \n" + input + " is odd.");
                }
               

                //Prompts user to continue or not
                Console.WriteLine("\nDo you want to continue?");

                string cont = Console.ReadLine();

                if (cont.ToLower() == "no" || cont.ToLower() == "n")
                {
                    run = false;
                    Console.WriteLine("Thanks for stopping by " + name + "!");
                    Thread.Sleep(1000);
                }


            } while (run);

        }
    }
}
