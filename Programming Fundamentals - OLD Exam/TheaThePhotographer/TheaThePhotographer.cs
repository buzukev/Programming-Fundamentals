using System;
using System.Collections.Generic;
using System.Linq;

namespace TheaThePhotographer
{
    public class TheaThePhotographer
    {
        public static void Main()
        {
            int totalPic = int.Parse(Console.ReadLine());
            int filterTime = int.Parse(Console.ReadLine());
            int filterFactor = int.Parse(Console.ReadLine());
            int uploadTime = int.Parse(Console.ReadLine());

            double totalFilteredPic = Math.Ceiling((totalPic * (double)(filterFactor / 100.0)));

            long timeForUpload = (long)totalPic * (long)filterTime;
            long timeForUploadFilteredPic = (long)uploadTime * (long)totalFilteredPic;

            long totalTimeUpload = timeForUpload + timeForUploadFilteredPic;

            Console.WriteLine($"{totalTimeUpload / 86400}:{totalTimeUpload % 86400 / 3600:d2}:{totalTimeUpload % 3600 / 60:d2}:{totalTimeUpload % 3600 % 60:d2}");
        }
    }
}