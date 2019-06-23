using System.Collections.Generic;
using System.Collections;
namespace Visitor
{
    public class Directory:Entry
    {
        private string name;
        private List<Entry> dir = new List<Entry>();
        // private ArrayList arr = new ArrayList();
        public Directory(string name){
            this.name = name;
        }
        public override string  getName(){
            return name;
        }
        public override int getSize(){
            int size = 0;
            foreach (var item in dir)
            {
                size += item.getSize();
            }
            return size;
        }
        public List<Entry> getDir(){
            return dir;
        }
        public override void add(Entry entry){
            dir.Add(entry);
        }
        public override void accept(Visitor v){
            v.visit(this);
        }

    }
}