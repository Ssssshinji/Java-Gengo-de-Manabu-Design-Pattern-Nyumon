using System;
using System.Collections.Generic;
namespace Factory
{
    public class IDCardFactory : Factories
    {
        private int serial = 1000;
        private List<string> owners = new List<string>(); 
        private Dictionary<string, string> database = new Dictionary<string, string>();
        //ID卡工厂的生产和注册
        public override Product createProduct(string owner){
            return new IDCard(owner, (serial++).ToString());
        }
        public override void registerProduct(Product product){
            this.owners.Add(((IDCard)product).getOwner());
            this.database.Add(((IDCard)product).getOwner(),((IDCard)product).getSerial());

        }
        //子类自定方法
        public List<string> getOwners(){
            return owners;
        }
        public void getDatabase(){
            foreach (var key in this.database.Keys)
            {
                Console.WriteLine(this.database[key]);
            }
        }

        
    }
}