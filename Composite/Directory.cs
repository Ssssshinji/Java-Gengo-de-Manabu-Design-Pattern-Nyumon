using System;
using System.Collections.Generic;
namespace Composite
{
    public class Directory : Entry
    {
        private string name;
        private List<Entry> directory = new List<Entry>();
        public Directory(string name){
            this.name = name;
        }
        public override string getName(){
            return this.name;
        }
        public override int getSize(){
            int size = 0;
            foreach (var item in directory)
            {
                size += item.getSize();
            }
            return size;
        }
        public override void add(Entry entry){
            entry.parent = this;
            this.directory.Add(entry);
        }
        public override void printList(string prefix){
            Console.WriteLine(prefix + "/" + this);
            foreach (var item in directory)
            {
                if((item is Directory)){
                    Directory d1 = (Directory) item;
                    d1.printList(prefix + "/" + name);
                    
                }
                else{
                    File f1 = (File) item;
                    f1.printList(prefix + "/" + name);
                }
                
                
            }
        }
    }
}