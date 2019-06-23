using System;
namespace Prototype
{
    public class MessageBox : Product
    {
        private char decochar;
        public MessageBox(char decochar){
            this.decochar = decochar;
        }
        public override void use(string s){
            int length = s.Length;
            for(int i = 0; i < length + 4; i++){
                Console.Write(decochar);
            }
            Console.WriteLine();
            //当你忘记这段代码为什么被注释掉的时候，运行一下
            // Console.WriteLine(decochar + ' ');
            Console.WriteLine(decochar + " " +  s + ' ' + decochar);
            for(int i = 0; i < length + 4; i++){
                Console.Write(decochar);
            }
            Console.WriteLine(); 
        }
    }
}