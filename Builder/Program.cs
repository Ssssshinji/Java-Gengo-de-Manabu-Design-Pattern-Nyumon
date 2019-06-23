using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            if(args.Length != 1){
                // Console.WriteLine("没有参数");
            }
            else if(args[0].Equals("plain")){
                TextBuilder tBuilder = new TextBuilder();
                Director director = new Director(tBuilder);
                director.construct();
                Console.WriteLine(tBuilder.getResult());
            }
            else if(args[0].Equals("html")){
                HTMLBuilder HBuilder = new HTMLBuilder();
                Director director = new Director(HBuilder);
                director.construct();
                Console.WriteLine(HBuilder.getResult() + "文件编写完成");              
            }
            else{
                Console.WriteLine("没有参数");
            }
        }
    }
}
