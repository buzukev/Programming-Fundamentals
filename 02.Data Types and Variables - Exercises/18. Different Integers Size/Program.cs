using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.Different_Integers_Size
{
    class Program
    {
        static void Main(string[] args)
        {
            //sbyte < byte < short < ushort < int < uint < long
            string number = Console.ReadLine();
            bool isCan = false;
            string message = "";

            try
            {
                sbyte sbyteNum = sbyte.Parse(number);
                message += "* sbyte\n";
                isCan = true;
            }
            catch (Exception)
            {
            }
            try
            {
                byte sbyteNum = byte.Parse(number);
                message += "* byte\n";
                isCan = true;
            }
            catch (Exception)
            {
            }
            try
            {
                short sbyteNum = short.Parse(number);
                message += "* short\n";
                isCan = true;
            }
            catch (Exception)
            {
            }
            try
            {
                ushort sbyteNum = ushort.Parse(number);
                message += "* ushort\n";
                isCan = true;
            }
            catch (Exception)
            {
            }
            try
            {
                int sbyteNum = int.Parse(number);
                message += "* int\n";
                isCan = true;
            }
            catch (Exception)
            {
            }
            try
            {
                uint sbyteNum = uint.Parse(number);
                message += "* uint\n";
                isCan = true;
            }
            catch (Exception)
            {
            }
            try
            {
                long sbyteNum = long.Parse(number);
                message += "* long";
                isCan = true;
            }
            catch (Exception)
            {
            }
            if (isCan)
            {
                Console.WriteLine($"{number} can fit in:");
                Console.WriteLine(message);
            }
            else
            {
                Console.WriteLine($"{number} can't fit in any type");
            }
        }
    }
}