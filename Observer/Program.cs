using System;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            NumberGenerator generator = new RandomNumberGenerator();
            Observer observer1 = new DigitObserver();
            Observer observer2 = new GraphObserver();
            generator.addObserver(observer1);
            generator.addObserver(observer2);
            generator.excute();
        }
    }
}
