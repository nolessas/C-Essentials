using System;
using System.Globalization;

namespace DateFormatConverter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your Date in MM/dd/yyyy");
            string name = Console.ReadLine();

            DateTime dateValue;
            if (DateTime.TryParseExact(inputDate, "MM/dd/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out dateValue))
            {
                string formattedDate = dateValue.ToString("dd-MM-yyyy");
                Console.WriteLine($"Formatted date: {formattedDate}");

            }
            else
            {
                Console.WriteLine("Invalid date format.");
            } 
            Console.ReadKey();
            
        }
    }
}