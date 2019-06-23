using System.Collections.Generic;
using System.Collections;
namespace Memento
{
    public class Memento
    {
        public int money;
        public ArrayList fruits;
        public int getMoney(){
            return money;
        }
        public Memento(int money){
            this.money = money;
            this.fruits = new ArrayList();
        }
        public void addFruit(string fruit){
            fruits.Add(fruit);
        }
        public List<string> getFruits(){
            List<string> fur = new List<string>();
            foreach (var item in fruits)
            {
                fur.Add((string)item);
            }
            return fur;
        }
    }
}