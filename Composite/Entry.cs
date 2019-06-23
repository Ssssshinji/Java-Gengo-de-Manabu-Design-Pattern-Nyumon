using System.Text;
namespace Composite
{
    public abstract class Entry
    {
        public Entry parent;
        public abstract string getName();
        public abstract int getSize();
        public void printList(){
            printList("");
        }
        public abstract void printList(string prefix);
        public virtual void add(Entry entry){
            
        }
        public override string ToString(){
            return getName() + "(" + getSize() + ")";
        }
        public string getFullName(){
            StringBuilder fullname = new StringBuilder();
            Entry entry = this;
            while (entry != null)
            {
                fullname.Insert(0,"/" + entry.getName());
                entry = entry.parent;
            }
            return fullname.ToString();
        }
    }
}