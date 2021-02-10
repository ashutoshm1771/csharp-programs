// Author : Ashutosh Mishra

using System;

namespace C__Programs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Basics of C# with Ashutosh Mishra");
            
            // This way is not possible for long data types
            // long a,b;
            // a = Convert.tolong( Console.ReadLine() );  
            // b = Convert.ToLong( Console.ReadLine() );  
            
            // Convert input ( by default, string) to double , using Convert.ToDouble 
            string a1 = Console.ReadLine(); // Enter a number, gets stored in string. 
            string b1 = Console.ReadLine();
            long a,b; //  Stores the required number 
            long.TryParse(a1, out a); // number variable now stored the required input value from user
            long.TryParse(b1,out b);
            
            Console.WriteLine("Your number is : " + a + " and "+b);
            Console.WriteLine("Sum = "+ (a+b) + " Difference = " + (a-b) + " Product = " + (a*b) + " Division = " + (a/b) + " Remainder = " + (a%b));
            Console.WriteLine("Is the first num divisible by the second num ? " + ( (a%b == 0)));

            long max = long.MaxValue , min = long.MinValue;
            Console.WriteLine(max + " " + min);
        }
    }
}
