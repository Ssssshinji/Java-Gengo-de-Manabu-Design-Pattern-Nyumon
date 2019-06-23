using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton sin1 = Singleton.getInstance();
            Singleton sin2 = Singleton.getInstance();

            if(sin1 == sin2){
                Console.WriteLine("这两个是相同的东西");
            }
        }
    }
}
