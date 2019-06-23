using System;
namespace Strategy
{
    public class ProbStrategy : Strategy
    {
        private Random random;
        private int prehandvalue = 0;
        private int currenthandvalue = 0;
        private int [,] history = {
            {1,1,1},
            {1,1,1},
            {1,1,1},
        };
        public ProbStrategy(int seed){
            random = new Random(seed);
        }
        public Hand nextHand(){
            int bet = random.Next(getSum(currenthandvalue));
            int handvalue = 0;
            if(bet < history[currenthandvalue,0]){
                handvalue = 0;
            }
            else if(bet < history[currenthandvalue,0] + history[currenthandvalue,1]){
                handvalue = 1;
            }
            else{
                handvalue = 2;
            }
            prehandvalue = currenthandvalue;
            currenthandvalue = handvalue;
            return Hand.getHand(handvalue);
        }
        private int getSum(int handvalue){
            int sum = 0;
            for(int i =0; i < 3; i++){
                sum += history[handvalue,i];
            }
            return sum;
        }
        public void study(bool win){
            if(win){
                history[prehandvalue,currenthandvalue]++;

            }else{
                history[prehandvalue,(currenthandvalue + 1) % 3] ++;
                history[prehandvalue,(currenthandvalue + 2) % 3] ++;

            }
        }
    }
}