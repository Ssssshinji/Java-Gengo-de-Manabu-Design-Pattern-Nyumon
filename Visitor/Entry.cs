using System.Collections.Generic;
namespace Visitor
{
    public abstract class Entry:Element
    {
        public abstract string getName();
        public abstract int getSize();
        public virtual void add(Entry entry){
            
        }
        public override string ToString(){
            return getName() + "(" + getSize() + ")";
        }
        public override void  accept(Visitor v){}
    }
}