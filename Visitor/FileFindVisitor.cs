using System.Collections.Generic;
using System;
using System.Collections;
namespace Visitor
{
    public class FileFindVisitor:Visitor
    {
        private string  filetype;
        private ArrayList  found = new ArrayList();
        public FileFindVisitor(string filetype){
            this.filetype = filetype;
        }
        public override void visit(File file){
            found.Add(file);
        }
        public override void visit(Directory directory){
            foreach (var item in directory.getDir())
            {
                item.accept(this);
            }
        }
    }
}