using System;
using ConsoleApp1.p;

namespace ConsoleApp1
{
    internal partial class Program
    {
        static void Main(string[] args)
        {

            var personal = new Person();
            personal.Firstname = "meysam";
            personal.Lastname = "saberi";
            personal.introduce();
            var calc = new Calc();
            var res = calc.Calculator(1, 2);
            Console.WriteLine(res);
            Console.WriteLine("{0} {1}" , 10,12);


        }
    }
}
