using System;
namespace Prototype
{
    public class underlinePen : Product
    {
        private char ulchar;
        public underlinePen(char ulchar){
            this.ulchar = ulchar;
        }
        public override void use(string s){
            int length = s.Length;
            Console.WriteLine('\'' + s + '\'');
            Console.Write(' ');
            for(int i = 0; i < s.Length; i++){
            Console.Write(ulchar);
            }
            Console.Write(' ');
            Console.WriteLine();
        }
    }
}