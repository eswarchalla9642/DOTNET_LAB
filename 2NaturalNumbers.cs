// Program to display the first 10 natural numbers and their sum using console application.

using System;

namespace MyApp 
{
    internal class NaturalNumbers
    {
        static void Main(string[] args)
        {
            int j, sum = 0;
            int num;
            Console.WriteLine("Enter a number:");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The first 10 natural number are :");
            for (j = 1; j <= num; j++)
            {
                sum = sum + j;
                Console.WriteLine("{0} ", j);
            }
            Console.WriteLine("The Sum is :{0}", sum);
        }
    }
}
