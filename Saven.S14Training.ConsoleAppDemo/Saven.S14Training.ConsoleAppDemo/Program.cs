using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;


namespace Saven.S14Training.ConsoleAppDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Name");
            string name = Console.ReadLine();
            Console.WriteLine("Welcome " + name);
            Console.WriteLine("Console Application Demo");

#if TRACE
            Trace.WriteLine("This is trace message..");
#endif 
#if DEBUG
            Debug.WriteLine("This is debug message");
#endif 
            Console.ReadLine();
        }
    }
}
