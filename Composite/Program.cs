﻿using System;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Making root entries...");
            Directory rootdir = new Directory("root");
            Directory bindir = new Directory("bindir");
            Directory tmpdir = new Directory("tmp");
            Directory usrdir = new Directory("usr");
            rootdir.add(bindir);
            rootdir.add(tmpdir);
            rootdir.add(usrdir);
            bindir.add(new File("vi", 10000));
            bindir.add(new File("latex", 20000));
            rootdir.printList();
            Console.WriteLine("file = " + bindir.getFullName());
        }
    }
}
