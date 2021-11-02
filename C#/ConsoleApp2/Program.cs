using System;
using System.Collections.Generic;
namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Program ceva = new Program();
            ceva.Print();
        }
        void Print()
        {
            Console.WriteLine("Hello World!");// comentariu
            Console.WriteLine("Best friend!");
            Console.WriteLine("Hey!");
        }
    }
}
// create the method
//invoke the method
//namespace->class->members->method->statements