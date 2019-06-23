using System;
using System.Threading;
namespace Proxy
{
    public class Printer : printable
    {
        private string name;
        
        public Printer(string name){
            heavyJob();
            this.name = name;
        }
        public void setPrinterName(string name){
            this.name = name;
        }
        public string getPrinterName(){
            return name;
            
        }
        public void Print(string str){
            Console.WriteLine("===" + name + "===");
            Console.WriteLine(str);
        }
        public void heavyJob(){
            Console.WriteLine("正在生成printer实例");
            for(int i = 0; i< 5; i++){
                Thread.Sleep(1000);
                Console.Write(".");
            }
            Console.WriteLine("\n结束");
        }
    }
}