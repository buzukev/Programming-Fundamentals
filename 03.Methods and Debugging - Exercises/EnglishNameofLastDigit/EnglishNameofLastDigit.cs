using System;

namespace EnglishNameofLastDigit
{
    public class EnglishNameofLastDigit
    {
        public static void Main()
        {
            long n = long.Parse(Console.ReadLine());
            string result = GetLastDigit(n);
            Console.WriteLine(result);
        }
        static string GetLastDigit(long number)
        {
            string lastDigitText = "";
            long lastDigitNumber = Math.Abs(number % 10);
            switch (lastDigitNumber)
            {
                case 0: lastDigitText = "zero"; break;
                case 1: lastDigitText = "one"; break;
                case 2: lastDigitText = "two"; break;
                case 3: lastDigitText = "three"; break;
                case 4: lastDigitText = "four"; break;
                case 5: lastDigitText = "five"; break;
                case 6: lastDigitText = "six"; break;
                case 7: lastDigitText = "seven"; break;
                case 8: lastDigitText = "eight"; break;
                case 9: lastDigitText = "nine"; break;
            }
            return lastDigitText;
        }
    }
}