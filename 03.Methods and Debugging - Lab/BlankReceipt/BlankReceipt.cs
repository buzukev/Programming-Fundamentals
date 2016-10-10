using System;

namespace BlankReceipt
{
    class BlankReceipt
    {
        static void PrintReceiptHeader()
        {
            Console.WriteLine($"CASH RECEIPT\r\n------------------------------");
        }
        static void PrintToBody()
        {
            Console.WriteLine($"Charged to____________________\r\nReceived by___________________\r\n------------------------------");
        }
        static void PrintToFooter()
        {
            Console.WriteLine($"\u00A9 SoftUni");
        }
        static void PrintReceipt()
        {
            PrintReceiptHeader();
            PrintToBody();
            PrintToFooter();
        }
        static void Main(string[] arg)
        {
            PrintReceipt();
        }
    }
}