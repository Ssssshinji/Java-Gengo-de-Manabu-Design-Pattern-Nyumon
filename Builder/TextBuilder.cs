using System;
using System.Text;
namespace Builder
{
    public class TextBuilder : Builder
    {
        private StringBuilder buffer = new StringBuilder();
        public void makeTitle(string title){
            buffer.Append("========================================\n");
            buffer.Append("《" + title +"》");
            buffer.Append("\n");
        }
        public void makeString(string str){
            buffer.Append('❀' + str + '\n');
            buffer.Append('\n');
        }
        public void makeItems(String[] items){
            for(int i = 0; i < items.Length; i++){
                buffer.Append(" ^" + items[i] + '\n');
            }
        }
        public void close(){
            buffer.Append("========================================\n");
        }
        public string getResult(){
            return buffer.ToString();
        }
    }
}