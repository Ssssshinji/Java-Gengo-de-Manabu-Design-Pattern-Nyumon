using System;
namespace Template
{
    public class StringDisplay : AbstractDisplay
    {
        private string str;
        private int width;
        public StringDisplay(string str){
            this.str = str;
            this.width = str.Length;
        }
        public override void open(){
            this.printLine();
        }
        public override void print(){
            Console.WriteLine('|' + this.str + '|');
        }
        public override void close(){
            this.printLine();
        }
        private void printLine(){
            Console.Write('+');
            for(int i = 0; i < this.width; i++){
                Console.Write('-');
            }
            Console.Write('+');
            Console.WriteLine();
        }
    }
}