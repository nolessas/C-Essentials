/*using System;
using System.Globalization;

namespace TitleCaseConverter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your Full name");
            string name = Console.ReadLine();

            TextInfo myTI = new CultureInfo("en-US", false).TextInfo;

            string titleCasename = myTI.ToTitleCase(name.ToLower());

            Console.WriteLine($"Your name is {titleCasename}");
            
            Console.ReadKey();
            
        }
    }
}*/