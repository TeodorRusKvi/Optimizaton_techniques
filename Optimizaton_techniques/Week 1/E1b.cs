//******************************************
//Implementation of Optimization Techniques - Part 1
//Program name:
//Author(s):
//Description:
//*******************************************

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optimizaton_techniques.Week_1
{
    class Template
    {
        //insert all Methods and class variables here
        
        static void Main(string[] args)
        {
            int number = 5;
            double value = 1.5;
            double multiplied = value * number;
            int halla = Convert.ToInt32(multiplied);

            Console.WriteLine("Please enter a number: ");
            int userInput = Console.ReadLine();
            int hei = Convert.ToInt32(userInput);

            Console.WriteLine(halla*hei);
            Console.WriteLine(halla);
            Console.WriteLine(multiplied);

        }
    }
}
