using System;
using System.Collections.Generic;
using System.Text;
namespace Memento
{
    public class Gamer
    {
        
        private int money;
        private List<string> fruits = new List<string>();
        private Random random = new Random();
        private static string[] fruitsname = {
            "苹果","葡萄","香蕉","橘子"
        };
        public Gamer(int money){
            this.money = money;
        }
        public int getMoney(){
            return money;
        }
        public void bet(){
            int dice = random.Next(6) + 1;
            if(dice == 1){
                money += 100;
                Console.WriteLine("所持金钱增加了。");
            }
            else if(dice == 2){
                money /= 2;
                Console.WriteLine("所持金钱减半了。");
            }else if(dice == 6){
                string f = getFruit();
                Console.WriteLine("获得了水果（" + f + "）。");
                fruits.Add(f);
            }else{
                Console.WriteLine("什么都没有发生。");
            }
        }
        public Memento createMemento(){
            Memento m = new Memento(money);
            foreach (var item in fruits)
            {
                if(item.StartsWith("好吃的")){
                    m.addFruit(item);
                }
            }
            return m;
        }
        public void restoreMemento(Memento memento){
            this.money = memento.money;
            this.fruits = (List<string>)memento.getFruits();
        }
        public override string ToString(){
            return "[money = " + money + ", fruits = " + getString() + "]";
        }
        public string getFruit(){
            string prefix = "";
            if(random.Next(2) == 1){
                prefix = "好吃的";
            }
            return prefix + fruitsname[random.Next(fruitsname.Length)];
        }
        public string getString(){
            StringBuilder builder = new StringBuilder();
            foreach (var item in fruits)
            {
             builder.Append(item + " ");
            }
            return builder.ToString();
        }
    }
}