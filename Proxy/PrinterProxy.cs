using System;
namespace Proxy
{
    public class PrinterProxy : printable
    {
        private string name;
        private printable real;
        private string className;
        public PrinterProxy(string name,string className){
            this.name = name;
            this.className = className;
        }
        public void setPrinterName(string name){
            this.name = name;
            if(real != null){
                real.setPrinterName(name);
            }
        }
        public string getPrinterName(){
            return name;
        }
        private void realize(){
            if(real == null){
                try
                {
                    Type t = Type.GetType("Proxy." + className);
                    // Type t = typeof(Printer);
                    // Console.WriteLine(t.Name);
                    real = (printable)Activator.CreateInstance(t, name);
                }
                catch (System.Exception)
                {
                    
                    throw;
                }
                
            }
        }
        public void Print(string str){
            realize();
            real.Print(str);
        }
    }
}