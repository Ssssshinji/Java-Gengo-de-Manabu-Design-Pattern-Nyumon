using System;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            printable p =new  PrinterProxy("Alice","Printer");
            Console.WriteLine("现在的名字是" + p.getPrinterName() + "。");
            p.setPrinterName("Bob");
            Console.WriteLine("现在的名字是" + p.getPrinterName() + "。");
            p.Print("Helle,world.");
        }
    }
}
