using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            int userInput = 0;

            while (true)
            {


                Console.WriteLine("Enter a number between 1-10: ");
                userInput = Convert.ToInt32(Console.ReadLine());
                long answer = 1;


                for (int i = 1; i <= userInput; i++)
                {
                    answer = answer * i;
                    Console.WriteLine(answer);
                }
                string input;
                Console.WriteLine("Continue? y/n");
                input = Console.ReadLine();

                if (input != "y")
                {
                    Console.WriteLine("bye");
                    break;
                }
                else
                {
                    
                    continue;
                }

                
                
            }

                     
        }
	

	}
    
}
