using System;

namespace Hello_Name_
{
    public class Hello_Name_
    {
        public static void Main()
        {
            PrintName();
        }

        private static void PrintName()
        {
            string name = Console.ReadLine();
            Console.WriteLine("Hello, {0}!", name);
        }
    }
}