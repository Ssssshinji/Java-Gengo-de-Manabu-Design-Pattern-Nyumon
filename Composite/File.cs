using System;
namespace Composite
{
    public class File : Entry
    {
        private string name;
        private int size;
        public File(string name, int size){
            this.name = name;
            this.size = size;
        }
        public override string getName(){
            return this.name;
        }
        public override int getSize(){
            return this.size;
        }
        //递归思想
        public override void printList(string prefix){
            Console.WriteLine(prefix + "/" + this);
        }
    }
}