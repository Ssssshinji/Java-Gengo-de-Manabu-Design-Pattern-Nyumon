using System;
using System.IO;
namespace Bridge
{
    public class FileDisplayImpl : DisplayImpl
    {
        private string filename;
        private StreamReader reader;
        public FileDisplayImpl(string filename){
            this.filename = filename;
        }
        public void rawopen(){
            try
            {
                reader = new StreamReader(filename);
            }
            catch (System.Exception)
            {
                
                throw;
            }
            Console.WriteLine("=-=-=-=-=-" + filename + "=-=-=-=-=-");
        }
        public void rawprint(){
            string line;
            while((line = reader.ReadLine()) != null){
                Console.WriteLine(line);
            }
        }
        public void rawclose(){
            try
            {
                reader.Close();
                
            }
            catch (System.Exception)
            {
                
                throw;
            }
        }
    }
}