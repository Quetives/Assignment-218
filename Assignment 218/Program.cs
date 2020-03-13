using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Assignment_218
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number:");
            string number = string.Format(Console.ReadLine());
            File.WriteAllText(@"C:\Users\Richard\Documents\logs\number.txt", number);
            string text = File.ReadAllText(@"C:\Users\Richard\Documents\logs\number.txt");
            Console.WriteLine(text);
            Console.ReadLine();
        }
    }
}
