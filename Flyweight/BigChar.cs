using System;
using System.IO;
using System.Text;

namespace Flyweight
{
    public class BigChar
    {
        private char charname;
        private string fontdata;
        public BigChar(char charname){
            this.charname = charname;
            using(StreamReader sr = new StreamReader("big" + charname + ".txt")){
                string line;
                StringBuilder sb = new StringBuilder();
                while((line = sr.ReadLine()) != null){
                    sb.Append(line);
                    sb.Append("\n");
                }
                sr.Close();
                this.fontdata = sb.ToString();
            }

        }
        public void print(){
            Console.WriteLine(fontdata);
        }
    }
}