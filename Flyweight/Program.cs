using System;

namespace Flyweight
{
    class Program
    {
        static void Main(string[] args)
        {
            BigString bs = new BigString(args[0]);
            bs.print();
        }
    }
}
