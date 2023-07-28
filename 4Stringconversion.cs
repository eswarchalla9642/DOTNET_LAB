//Write a program to convert input string from lower to upper and upper to lower case.

using System;

namespace MyApp
{
    internal class StringConversion
    {
        static void Main(string[] args)
        {
            String str1,str2;
            Console.WriteLine("Enter first String:");
            str1 = Console.ReadLine();
            Console.WriteLine("Enter second string:");
            str2 = Console.ReadLine();
             Console.WriteLine("Upper case string : {0}", str1.ToUpper());
            Console.WriteLine("Lower case string : {0}", str2.ToLower());
        }
    }
}
