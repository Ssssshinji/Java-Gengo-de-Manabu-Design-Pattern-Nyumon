using System;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            //拥有四本空书的书架
            BookShelf bookShelf = new BookShelf();
            //增加四本书进去
            bookShelf.appendBook(new Book("Around the World in 80 Days"));
            bookShelf.appendBook(new Book("Blble"));
            bookShelf.appendBook(new Book("Cinderella"));
            bookShelf.appendBook(new Book("Daddy-Long-Legs"));
            bookShelf.appendBook(new Book("Daddy-Long-Legs"));
            bookShelf.appendBook(new Book("Daddy-Long-Legs"));
            bookShelf.appendBook(new Book("Daddy-Long-Legs"));
            bookShelf.appendBook(new Book("Daddy-Long-Legs"));
            bookShelf.appendBook(new Book("Daddy-Long-Legs"));
            bookShelf.appendBook(new Book("Daddy-Long-Legs"));
            bookShelf.appendBook(new Book("Daddy-Long-Legs"));
            Iiterator it = bookShelf.iterator();
            while(it.hasNext()){
                Book book = (Book)it.next();
                Console.WriteLine(book.getName());
            }
        }
    }
}
