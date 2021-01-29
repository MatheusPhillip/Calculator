using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectCalculator.Model
{
    class Calculator
    {
        public static void Sum(float num1, float num2)
        {
            float result = num1 + num2;
            Console.WriteLine("Result: " + result);
        }
        public static void Subtract(float num1, float num2)
        {
            float result = num1 - num2;
            Console.WriteLine("Result: " + result);
        }
        public static void Multiple(float num1, float num2)
        {
            float result = num1 * num2;
            Console.WriteLine("Result: " + result);
        }
        public static void Divide(float num1, float num2)
        {
            float result = num1 / num2;
            Console.WriteLine("Result: " + result);
        }
    }
}
