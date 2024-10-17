using Optimizaton_techniques.Week_1;
using System;
using System.Collections.Generic;
using System.Diagnostics.PerformanceData;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optimizaton_techniques.Week_1
{
    internal class E1c
    {
     
        public float AskForNumber() 
        {

            Console.WriteLine("Write a number");
            string userInput = Console.ReadLine();
            float number = Convert.ToSingle(userInput);
            Console.WriteLine($"this is your {number} ");

            return number;

        }

        public void ConvertToTime(float number)
        {
            int hours = (int)((number / 60) / 60);
            int minutes = (int)(number / 60); // Get the whole number of minutes
            float remainder = number % 60; // Get the remaining part for seconds

            Console.WriteLine($"{hours}h:{minutes}m:{remainder}s");
        }

        public void Process()
        {
            float number = AskForNumber();
            ConvertToTime(number);
        }


    }
}


class Program
{
    static void Main(string[] args)
    {
        // Create an instance of the E1c class
        E1c e1cInstance = new E1c();

        // Call the Process method to ask for the number and convert it to time
        e1cInstance.Process();

        // Keep the console open after running
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}