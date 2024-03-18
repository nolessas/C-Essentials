using System;
using System.Text.Json;

namespace JSONConverter 
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Occupation { get; set; }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            var person = new Person
            {
                Name = "John Doe",
                Age = 30,
                Occupation = "Software Developer"
            };

            string jsonString = JsonSerializer.Serialize(person);
            Console.WriteLine(jsonString);
        }
    }
}
