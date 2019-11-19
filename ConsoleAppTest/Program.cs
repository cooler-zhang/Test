using System;
using System.Collections.Generic;

namespace ConsoleAppTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var items = new List<string>() { "a", "b", "c" };
            items.ForEach(a =>
            {
                if (a == "b")
                    return;
                Console.WriteLine(a);
            });
            Console.ReadLine();
        }
    }
}
