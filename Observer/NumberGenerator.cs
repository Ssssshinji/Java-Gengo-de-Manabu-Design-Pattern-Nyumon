using System.Collections.Generic;
namespace Observer
{
    public abstract class NumberGenerator
    {
        private List<Observer> observers = new List<Observer>();
        public void addObserver(Observer observer){
            observers.Add(observer);
        }
        public void deleteObserver(Observer observer){
            observers.Remove(observer);
        }
        public void notifyObservers(){
            foreach (var item in observers)
            {
                item.update(this);
            }
        }
        public abstract int getNumber();
        public abstract void excute();
    }
}