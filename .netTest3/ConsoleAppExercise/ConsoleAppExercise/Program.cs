
using System;

namespace ConsoleAppExercise
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /*
           You have the following values to convert:

            byte a = 10; //Convert this value into "short" type (assign into another short type of variable)
            int b = 10; //Convert this value into "short" type (assign into another short type of variable)
            string c = "10.34"; //Convert this value into "double" type using Parse  //Also, convert the same value into "decimal" type  using TryParse
            decimal d; //Convert this value into "string" type (assign into another string type of variable)
            And then print all the converted values i.e 10, 10, 10.34, 10.34, 11.56.

            You need to consider this order of concepts to prefer for conversion, where the "1" will be the highest priority and the "4" will be the least priority.

            Implicit Casting

            Explicit Casting

            Parse or TryParse (as suggested above)

            Conversion Methods
           */

            // Values to Convert

            byte a = 10;
            int b = 10; 
            string c = "10.34";
            decimal d = 11.56M;
    
            short xa = a;
            short xb = (short)b;
            double xc = double.Parse(c);
            decimal.TryParse(c, out decimal m);
            string xe = Convert.ToString(d);

            Console.WriteLine(xa);
            Console.WriteLine(xb);
            Console.WriteLine(xc);
            Console.WriteLine(m);
            Console.WriteLine(xe);
            Console.ReadKey();

        }
  
    }
}
