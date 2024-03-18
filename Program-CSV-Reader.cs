using System;
using System.IO;

namespace CSVParser
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\Razer\Desktop\data.csv";


            try
            {
                using (var reader = new StreamReader(filePath))
                {
                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        var values = line.Split(',');

                        Console.WriteLine($"Name: {values[0]}, Age: {values[1]}, Occupation: {values[2]}");
                    }
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("The file was not found: " + filePath);
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }
    }
}
