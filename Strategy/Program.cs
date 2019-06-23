using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            if(args.Length != 2){
                Console.WriteLine("输入参数错误");
            }
            int seed1 = Int32.Parse(args[0]);
            int seed2 = Int32.Parse(args[1]);
            Player p1 = new Player("zhuyuetong", new WinningStrategy(seed1));
            Player p2 = new Player("zhaoyuchen", new WinningStrategy(seed2));
            for(int i = 0; i < 10; i++){
                Hand hand1 = p1.nextHand();
                Hand hand2 = p2.nextHand();
                if(hand1.isStrongerThan(hand2)){
                    Console.WriteLine("winner" + p1.toString());
                    p1.win();
                    p2.lose();
                }
                else if(hand2.isStrongerThan(hand1)){
                    Console.WriteLine("winner" + p2.toString());
                    p1.lose();
                    p2.win();
                }
                else{
                    p1.even();
                    p2.even();
                    Console.WriteLine("even");
                }
            }
            Console.WriteLine("Total result:");
            Console.WriteLine(p1.toString());
            Console.WriteLine(p2.toString());

        }
    }
}
