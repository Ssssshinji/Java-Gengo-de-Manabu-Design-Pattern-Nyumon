using System.Collections.Generic;
using System;
namespace Visitor
{
    public class ListVisitor:Visitor
    {
        private string currentdir = "";
        public override void visit(File file){
            Console.WriteLine(currentdir + "/" + file);
        }
        public override void  visit(Directory directory){
            Console.WriteLine(currentdir + "/" + directory);
            string savedir = currentdir;
            currentdir = currentdir + "/" + directory.getName();
            foreach (var item in directory.getDir())
            {
                item.accept(this);
            }
            currentdir = savedir;
        }
    }
}