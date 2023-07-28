//Program to display the addition, subtraction, multiplication and division of two number using console applications.

using System;

namespace MyApp 
{
    internal class BasicOperations
    {
        static void add(float a, float b)
        {
            Console.WriteLine("Addition:" + (a + b));
        }
        static void sub(float a, float b)
        {
            Console.WriteLine("Subtraction:" + (a - b));
        }
        static void mul(float a, float b)
        {
            Console.WriteLine("Multiplication:" + (a * b));
        }
        static void div(float a, float b)
        {
            Console.WriteLine("Division:" + (a / b));
        }
        public static void Main()
        {
         
            Console.WriteLine("Mathematical Operations");
            Console.WriteLine("Enter a first number:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            int num2 = Convert.ToInt32(Console.ReadLine());
            add(num1, num2);
            sub(num1, num2);
            mul(num1, num2);
            div(num1, num2);
        }
    }
}
