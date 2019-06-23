using System;
namespace Bridge
{
    public class RandomCountDisplay : CountDisplay
    {
        public RandomCountDisplay(DisplayImpl impl) : base(impl){

        }
        public void RandomDisplay(int times){
            multiDisplay(new Random().Next(times));
        }

        
    }
}