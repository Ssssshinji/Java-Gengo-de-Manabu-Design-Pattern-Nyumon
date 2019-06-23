using System;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            underlinePen ul = new underlinePen('~');
            MessageBox mb1 = new MessageBox('/');
            MessageBox mb2 = new MessageBox('P');
            Manager manager = new Manager();
            manager.register("strong message", ul);
            manager.register("star message", mb2);
            manager.register("slash message", mb1);
            Product p1 = manager.create("strong message");
            p1.use("nimajinwanbisi");
            Product p2 = manager.create("star message");
            p2.use("nimajinwanbisi");
            Product p3 = manager.create("slash message");
            p3.use("nimajinwanbisi");

        }
    }
}
