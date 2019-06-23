using System;
namespace Singleton
{
    public class Singleton
    {
        private static Singleton singleton = new Singleton();
        private Singleton(){
            Console.WriteLine("生成了一个实例");
        }
        public static Singleton getInstance(){
            return singleton;
        }

    }
}


