//Write a program to implement namespace in C#

using System;

namespace firstspace
{
    class a
    {
        public void func1()
        {
            Console.WriteLine("First function");
        }
    }
}
namespace secondspace
{
    class b
    {
        public void func2()
        {
            Console.WriteLine("Second function");
        }
    }
}
class Test
{
    public static void Main(String[] args)
    {
        firstspace.a first = new firstspace.a();
        secondspace.b second = new secondspace.b();
        first.func1();
        second.func2();
        
    }
}
