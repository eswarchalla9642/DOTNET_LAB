//Write a program to implement threading in C#


using System;
using System.Threading;

class Threads
{
    static void Main(string[] args)
    {
        Thread thr = new Thread(mythread);
        thr.Start();
        Console.WriteLine("Main Thread Ends!!");
    }

    static void mythread()
    {
        for (int c = 0; c <= 3; c++)
        {

            Console.WriteLine("mythread is in progress!!");
            Thread.Sleep(1000);
        }
        Console.WriteLine("mythread ends!!");
    }
}
