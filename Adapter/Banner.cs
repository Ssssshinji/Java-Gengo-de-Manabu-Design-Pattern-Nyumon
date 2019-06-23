using System;
namespace Adapter
{
    public class Banner
    {
        private string text;
        public Banner(string text){
            this.text = text;
        }
        public void showWithParen(){
            Console.WriteLine('(' + this.text + ')');
        }
        public void showWithAster(){
            Console.WriteLine('*' + this.text + '*');
        }
    }
}