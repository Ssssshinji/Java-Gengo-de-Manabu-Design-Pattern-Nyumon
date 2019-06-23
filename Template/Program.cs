using System;

namespace Template
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractDisplay d1 = new CharDisplay('S');
            AbstractDisplay d2 = new StringDisplay("helloWorld");
            d1.display();
            d2.display();
        }
    }
}
