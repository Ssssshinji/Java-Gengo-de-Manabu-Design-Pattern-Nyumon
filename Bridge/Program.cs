using System;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            Display d1 = new Display(new StringDisplayImpl("Hello China"));
            Display d2 = new CountDisplay(new StringDisplayImpl("Hello World."));
            CountDisplay d3 = new CountDisplay(new StringDisplayImpl("hello Universe."));
            RandomCountDisplay d4 = new RandomCountDisplay(new StringDisplayImpl("hello Random."));
            CountDisplay d6 = new CountDisplay(new FileDisplayImpl("let's go.txt"));
            d1.display();
            d2.display();
            d3.display();
            d3.multiDisplay(5);
            d4.RandomDisplay(5);
            d6.multiDisplay(3);
        }
    }
}
