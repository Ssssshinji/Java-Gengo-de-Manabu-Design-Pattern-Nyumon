using System.Collections.Generic;
namespace Prototype
{
    public class Manager
    {
        private Dictionary<string, Product> showcase = new Dictionary<string, Product>();
        public void register(string protoname, Product product){
            this.showcase.Add(protoname,product);
        }
        public Product create(string protoname){
            Product p = (Product)this.showcase[protoname].Clone();
            return p;
        }
    }
}