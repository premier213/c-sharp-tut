using System;

namespace ConsoleApp1.p
{
    public class Person
    {
        public string Firstname;
        public string Lastname;
        static string File;
        public void introduce()
        {
            Console.WriteLine("my name is " + Firstname + " " + Lastname);
            Console.WriteLine(File);
        }
    }
}
