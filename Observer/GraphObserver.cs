using System;
using System.Threading;
namespace Observer
{
    public class GraphObserver : Observer
    {
        public void update(NumberGenerator generator){
            Console.WriteLine("GraphObserver:");
            int count = generator.getNumber();
            for(int i = 0; i< count; i++){
                Console.Write("*");
            }
            Console.WriteLine();
            Thread.Sleep(100);
        }
    }
}