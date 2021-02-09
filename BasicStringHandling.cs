using System;

namespace C__Programs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Basics of C# with Ashutosh Mishra");
            string name;
            Console.WriteLine("Enter your name"); // stdout
            name = Console.ReadLine(); // stdin
            Console.WriteLine("Hi, "+name); // Normal string printing
            Console.WriteLine($"Hello {name}"); // String Interpolation 
            Console.WriteLine($"Your name is {name.Length} letters long");
            Console.WriteLine($"Your name contains a ? {name.Contains("a")}. And it starts with as ? {name.StartsWith("as")}.");
            Console.WriteLine($"Your name ends with u ? {name.EndsWith("u")}");
        }
    }
}
