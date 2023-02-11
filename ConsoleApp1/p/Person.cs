using System;

namespace ConsoleApp1.p
{
        public class Person
        {
            public string Firstname;
            public string Lastname;
            public void introduce()
            {
                Console.WriteLine("my name is " + Firstname + " " + Lastname);
            }
        }
}
