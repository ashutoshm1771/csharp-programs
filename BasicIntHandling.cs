// Author : Ashutosh Mishra

using System;

namespace C__Programs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Basics of C# with Ashutosh Mishra");
            int a,b;
            a = Convert.ToInt32( Console.ReadLine() );  
            b = Convert.ToInt32( Console.ReadLine() );  
            
            /*
                // Convert input ( by default, string) to int32 , using Convert.ToInt32
                // Next way is this --> 
                    string name = Console.ReadLine(); // Enter a number, gets stored in string. 
                    int number; //  Stores the required number 
                    Int32.TryParse(name, out number); // number variable now stored the required input value from user
            */
            Console.WriteLine("Your number is : " + a + " and "+b);
            Console.WriteLine("Sum = "+ (a+b) + " Difference = " + (a-b) + " Product = " + (a*b) + " Division = " + (a/b) + " Remainder = " + (a%b));
            Console.WriteLine("Is the first num divisible by the second num ? " + ( (a%b == 0)));
            
            int max = int.MaxValue , min = int.MinValue;
            Console.WriteLine(max + " " + min);
        }
    }
}
