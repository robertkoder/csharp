using System;
using System.Collections.Generic;

namespace csharp
{
    class Program
    {
        static void Main(string[] args)
        {

            int x = 5;
            double y = 0.15;
            string stringTest = "Percentage of 5 in 10 = ";

            // define and intialize an array and a list
            string[] stringArray = {"Hello", "world", "from", "array"};
            List<double> doubleList = new List<double> {3.14, 2.71, 1.41, 1.73};

            // print array and list
            Console.WriteLine("\nArray elements:");
            foreach (var item in stringArray)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nList elements:");
            foreach (var item in doubleList)
            {
                Console.WriteLine(item);
            }

            // make person
            Person person = new Person("John Doe", 30);
            Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");

            // testing calculator
            ICalculator calculator = new Calculator();
            Console.WriteLine("10 + 5 = " + calculator.Add(10, 5));
            Console.WriteLine("10 - 5 = " + calculator.Subtract(10, 5));
            Console.WriteLine("10 * 5 = " + calculator.Multiply(10, 5));
            Console.WriteLine("10 / 5 = " + calculator.Divide(10, 5));
            Console.WriteLine(stringTest + calculator.Percentage(5, 10) + "%");
        }
    }
}