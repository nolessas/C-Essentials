using System;
using System.Globalization;

namespace DateFormatConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a date in MM/dd/yyyy format:");
            string inputDate = Console.ReadLine();

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
        }
    }
}
