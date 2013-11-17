using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Generate the Fibonacci sequence to how many numbers?");
            int count;
            int fibSequence = 1;
            int fibLast = 0;
            int fibNext = fibLast + fibSequence;

//get user input
    
                try
                {
                    count = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    count = 0;
                }
            if (count < 1)

            {
                Console.WriteLine("Welp, I'm done here, I guess.");
            }
            else
            {
//loop through and print the Fibonacci sequence
                for (int i = 0; i < count; i++)
                {
                    Console.Write(fibSequence.ToString()+" ");
                    
                    fibLast = fibSequence;
                    fibSequence = fibNext;
                    fibNext = fibLast + fibSequence;
                }
                Console.WriteLine();                        //End the line
            }
            Console.ReadLine();                             //Pause at end of program
        }
    }
}
