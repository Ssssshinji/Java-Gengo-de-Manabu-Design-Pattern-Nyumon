﻿using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Display d1 = new StringDisplay("Hello World.");
            Display d2 = new SideBorder(d1, '#');
            Display d3 = new FullBorder(d2);
            d1.show();
            d2.show();
            d3.show();
            Display d4 = new UpDownBorder(d3, '+');
            d4.show();
        }
    }
}
