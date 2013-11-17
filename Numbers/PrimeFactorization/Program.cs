using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeFactorization
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number to factor:");
            string factorme = Console.ReadLine();
            int factor_num = 0;

            try
            {
                factor_num = int.Parse(factorme);
            }
            catch (Exception)
            {
                Console.WriteLine("That's not playing fair!");
            }
            Console.WriteLine("I will now factor the number: {0}", factor_num.ToString());
            Console.ReadLine();
        }
    }
}
