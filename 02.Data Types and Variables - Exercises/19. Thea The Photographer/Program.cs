using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.Thea_The_Photographer
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalPictures = int.Parse(Console.ReadLine());
            int filterTime = int.Parse(Console.ReadLine());
            int filterFactor = int.Parse(Console.ReadLine());
            int uploadTime = int.Parse(Console.ReadLine());
            double filterFactorinPercent = filterFactor / 100.0;
            double filterPictures = Math.Ceiling(totalPictures * filterFactorinPercent);
            long PicFilterTime = (long)totalPictures * (long)filterTime;
            long PicUploadTime = (long)filterPictures * (long)uploadTime;
            long totalTime = PicFilterTime + PicUploadTime;
            Console.WriteLine($"{(totalTime / 86400)}:{(totalTime % 86400 / 3600):d2}:{(totalTime % 3600 / 60):d2}:{(totalTime % 3600 % 60):d2}");
        }
    }
}