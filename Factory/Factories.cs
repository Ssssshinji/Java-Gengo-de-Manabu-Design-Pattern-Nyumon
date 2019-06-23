//框架包，工厂
namespace Factory
{
    public abstract class Factories
    {
        //制作的方法，始终调用父类的
        public Product create(string owner){
            Product p = createProduct(owner);
            registerProduct(p);
            return p;
        }
        //定义了生产和注册两个方法
        public abstract Product createProduct(string owner);
        public abstract void registerProduct(Product product);
    }
}