using System;
using System.Threading;
namespace Observer
{
    public class DigitObserver : Observer
    {
        public void update(NumberGenerator generator){
            Console.WriteLine("DigitObserver:" + generator.getNumber());
            Thread.Sleep(100);
        }
    }
}