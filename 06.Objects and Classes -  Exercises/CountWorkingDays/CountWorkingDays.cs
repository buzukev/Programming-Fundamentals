using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;


public class CountWorkingDays
{
    public static void Main()
    {
        var startDateStr = Console.ReadLine();
        var endDateStr = Console.ReadLine();

        DateTime startDate = DateTime.ParseExact(startDateStr, "dd-MM-yyyy", CultureInfo.InvariantCulture);
        DateTime endDate = DateTime.ParseExact(endDateStr, "dd-MM-yyyy", CultureInfo.InvariantCulture);

        var holidays = new DateTime[11];

        holidays[0] = new DateTime(2004, 01, 01);
        holidays[1] = new DateTime(2004, 03, 03);
        holidays[2] = new DateTime(2004, 05, 01);
        holidays[3] = new DateTime(2004, 05, 06);
        holidays[4] = new DateTime(2004, 05, 24);
        holidays[5] = new DateTime(2004, 09, 06);
        holidays[6] = new DateTime(2004, 09, 22);
        holidays[7] = new DateTime(2004, 11, 01);
        holidays[8] = new DateTime(2004, 12, 24);
        holidays[9] = new DateTime(2004, 12, 25);
        holidays[10] = new DateTime(2004, 12, 26);

        int workingDaysCounter = 0;

        for (DateTime i = startDate; i <= endDate; i = i.AddDays(1))
        {
            DayOfWeek day = i.DayOfWeek;

            DateTime temp = new DateTime(2004, i.Month, i.Day);

            if (!holidays.Contains(temp) && !day.Equals(DayOfWeek.Saturday) && !day.Equals(DayOfWeek.Sunday))
            {
                workingDaysCounter++;
            }
        }

        Console.WriteLine(workingDaysCounter);
    }
}