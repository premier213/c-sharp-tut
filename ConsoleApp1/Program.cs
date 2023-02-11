using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numner=2;
            int count = 256;
            bool hasCount = false;
            float dec = 3.25f;
            char character = 'a';
            string firstName = "meysam";
            Console.WriteLine(numner);
            Console.WriteLine(count);
            Console.WriteLine(hasCount);
            Console.WriteLine(dec);
            Console.WriteLine(character);
            Console.WriteLine(firstName);
            Console.WriteLine("{0},{1}", byte.MinValue, byte.MaxValue);

            //conver 
            float b = 0.0f;
            int c = (int)b;

            string f = "1";

            int j = int.Parse(f);
            Console.WriteLine(j);


        }
    }
}
