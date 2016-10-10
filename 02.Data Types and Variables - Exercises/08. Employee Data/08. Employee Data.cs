using System;

namespace _08.Employee_Data
{
    class Program
    {
       public static void Main()
        {
            string firstName = "Amanda";
            string lastName = "Jonson";
            byte age = 27;
            char gender = 'f';
            double idNumber = 8306112507;
            int employeeNumber = 27563571;
            Console.WriteLine($"First name: {firstName}\nLast name: {lastName}\nAge: {age}\nGender: {gender}\nPersonal ID: {idNumber}\nUnique Employee number: {employeeNumber}");
        }
    }
}