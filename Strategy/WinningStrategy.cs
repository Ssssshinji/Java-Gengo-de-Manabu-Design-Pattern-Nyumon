using System;
namespace Strategy
{
    public class WinningStrategy : Strategy
    {
        private Random random;
        private bool won = false;
        private Hand prehand;
        public WinningStrategy(int seed){
            random = new Random(seed);
        }
        public Hand nextHand(){
            if(!won){
                prehand = Hand.getHand(random.Next(3));
            }
            return prehand;
        }
        public void study(bool win){
            won = win;
        }
    }
}