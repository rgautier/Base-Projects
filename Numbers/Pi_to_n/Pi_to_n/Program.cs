using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pi_to_n
{
    class Program
    {
        static void Main(string[] args)
        {
            //Maximum is 15 due to Math.PI only containing that many digits
            //Minimum is 1 which will print 3.

            Console.WriteLine("Figuring pi to {0} digit(s)", args[0]);  //Args in C# does not include executable
            string myformat = "{0:#.";                                  //Starting off the string format with at least one digit

            for (int i = 1; i < int.Parse(args[0]); i++)
            {
                myformat = myformat + "#";
            }
            myformat = myformat + "}";                                  //End the format string to complete the {}

            Console.WriteLine(myformat, Math.PI);                       //Outputs the format we built to limit the pic print
            Console.ReadLine();
        }
    }
}
