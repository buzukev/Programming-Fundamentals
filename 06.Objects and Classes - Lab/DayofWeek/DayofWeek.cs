using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace DayofWeek
{
    public class DayofWeek
    {
        public static void Main()
        {
            var dateString = Console.ReadLine();
            var result = dateString.Split('-').Select(int.Parse).ToArray();
            var date = new DateTime(result[2], result[1], result[0]);
            Console.WriteLine(date.DayOfWeek);
        }
        /*
            //variant two

            string dateAsText = Console.ReadLine();
            DateTime date = DateTime.ParseExact(dateAsText, "d-M-yyyy", CultureInfo.InvariantCulture);
            Console.WriteLine(date.DayOfWeek);
        }*/
    }
}