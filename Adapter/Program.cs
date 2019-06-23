using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Print p = new PrintBanner("nimasilegege");
            p.printWeak();
            p.printStrong();
        }
    }
}
