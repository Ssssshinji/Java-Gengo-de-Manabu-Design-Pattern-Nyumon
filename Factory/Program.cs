using System;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            Factories IDFac = new IDCardFactory();
            Product IDcard1 = IDFac.createProduct("第1位同学");
            Product IDcard2 = IDFac.createProduct("第2位同学");
            Product IDcard3 = IDFac.createProduct("第3位同学");
            ((IDCardFactory)IDFac).getDatabase();
        }
    }
}
