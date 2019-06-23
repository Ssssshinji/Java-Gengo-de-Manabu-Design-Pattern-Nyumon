namespace Adapter
{
    public class PrintBanner : Banner,Print
    {
        public PrintBanner(string text):base(text){}
        public void printWeak(){
            showWithParen();
        }
        public void printStrong(){
            showWithAster();
        }
    }
}