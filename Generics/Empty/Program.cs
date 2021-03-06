﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empty
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] charArray = { 'a', 'D', '%' };
            double[] doubleArray = { 1.9, 3.8, 5.3, 9.3 };

            PrintArray(charArray);
            PrintArray(doubleArray);

            Console.WriteLine("=== ArrayPrint Demo ===");
            ArrayPrintDemo.Demo();

            Console.WriteLine("=== MyCollection Demo ===");
            MyCollection.Demo();

            Console.WriteLine("=== Exercise 1 ===");
            Exercise1.Demo();

            Console.WriteLine("=== Exercise 2 ===");
            Exercise2.Demo();

            Console.WriteLine("=== Constraint Demo ===");
            ConstraintDemo.Demo();

            Console.ReadKey();
        }

        public static void PrintArray(char[] inputArray)
        {
            foreach (char element in inputArray)
            {
                Console.WriteLine(element);
            }
        }

        public static void PrintArray(double[] inputArray)
        {
            foreach (double element in inputArray)
            {
                Console.WriteLine(element);
            }
        }

       
    }
}
