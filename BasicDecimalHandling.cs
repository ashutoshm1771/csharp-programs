// Author : Ashutosh Mishra

using System;

namespace C__Programs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Basics of C# with Ashutosh Mishra");
            decimal a,b;
            a = Convert.ToDecimal( Console.ReadLine() );  
            b = Convert.ToDecimal( Console.ReadLine() );  
            /*
                // Convert input ( by default, string) to double , using Convert.ToDouble
                // Next way is this --> 
                    string name = Console.ReadLine(); // Enter a number, gets stored in string. 
                    double number; //  Stores the required number 
                    Double.TryParse(name, out number); // number variable now stored the required input value from user
            */
            Console.WriteLine("Your number is : " + a + " and "+b);
            Console.WriteLine("Sum = "+ (a+b) + " Difference = " + (a-b) + " Product = " + (a*b) + " Division = " + (a/b) + " Remainder = " + (a%b));
            Console.WriteLine("Is the first num divisible by the second num ? " + ( (a%b == 0)));

            decimal max = decimal.MaxValue , min = decimal.MinValue;
            Console.WriteLine(max + " " + min);
        }
    }
}
