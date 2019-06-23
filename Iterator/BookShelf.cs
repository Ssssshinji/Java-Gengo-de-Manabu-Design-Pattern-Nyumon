using System;
using System.Collections.Generic;
public class BookShelf : Iaggregate{
    // private Book[] books;
    //利用泛型list来扩展
    private List<Book> books;
    // private int last = 0;
    public BookShelf(){
        // books = new Book[maxsize];
        //利用泛型list来扩展
        books = new List<Book>();
    }
    public Book getBookAt(int index){
        return books[index];
    }
    public void appendBook(Book book){
        // books[last] = book;
        // last++;
        //利用泛型list来扩展
        books.Add(book);
    }
    public int getLength(){
        return books.Count;
    }
    public Iiterator iterator(){
        return new BookShelfiterator(this);
    }
}
