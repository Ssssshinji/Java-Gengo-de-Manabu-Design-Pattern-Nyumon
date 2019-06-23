using System;
namespace Observer
{
    public class RandomNumberGenerator : NumberGenerator    
    {
        private Random random = new Random(60);
        private int number;
        public override int getNumber(){
            return number;
        }
        public override void excute(){
            for(number = 10; number < 50; number+=5){
                
                notifyObservers();
            }

        }
    }
}