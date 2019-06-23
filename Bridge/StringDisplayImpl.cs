using System;
using System.Text;
namespace Bridge
{
    public class StringDisplayImpl : DisplayImpl
    {
        private string str;
        private int width;
        public StringDisplayImpl(string str){
            this.str = str;
            this.width = Encoding.Default.GetBytes(str).Length;

        }
        public void rawopen(){
            printLine();
        }
        public void rawprint(){
            Console.WriteLine("|" + str + '|');
        }
        public void rawclose(){
            printLine();
        }
        private void printLine(){
            Console.Write("+");
            for(int i = 0; i < width; i++){
                Console.Write("-");
            }
            Console.WriteLine("+");
        }
    }
}