using System;
using System.Threading;

namespace Memento
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer = new Gamer(100);
            Memento memento = gamer.createMemento();
            for(int i = 0; i < 10; i++){
                Console.WriteLine("=====", + i);
                Console.WriteLine("当前状态:" + gamer);
                gamer.bet();
                Console.WriteLine("所持金钱为" + gamer.getMoney() + "元。");
                if(gamer.getMoney() > memento.getMoney()){
                    Console.WriteLine("金钱增加了不少，保存游戏状态。");
                    memento = gamer.createMemento();
                }
                else if( gamer.getMoney() < memento.getMoney()){
                    Console.WriteLine("金钱减少了许多，回复之前的状态。");
                    gamer.restoreMemento(memento);
                }

                try
                {
                    Thread.Sleep(1000);
                }
                catch (System.Exception)
                {
                    
                    throw;
                }
            }
        }
    }
}
