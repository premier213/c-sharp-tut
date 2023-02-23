using System;
using ConsoleApp1.p;

namespace ConsoleApp1
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();

            person.Firstname = "Test";

            Console.WriteLine(person.Firstname);

        }
    }
}
