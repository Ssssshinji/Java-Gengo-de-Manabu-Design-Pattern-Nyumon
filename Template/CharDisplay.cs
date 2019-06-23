using System;
namespace Template
{
    public class CharDisplay : AbstractDisplay
    {
        private char ch;
        public CharDisplay(char ch){
            this.ch = ch;
        }

        public override void open(){
            Console.Write("<<");
        }

        public override void print(){
            Console.Write(this.ch);
        }
        public override void close(){
            Console.WriteLine(">>");
        }
    }
}