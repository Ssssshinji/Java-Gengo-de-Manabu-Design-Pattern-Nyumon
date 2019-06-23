public class BookShelfiterator : Iiterator{
    private BookShelf bookShelf;
    private int index;
    public BookShelfiterator(BookShelf bookShelf){
        this.bookShelf = bookShelf;
        index = 0;
    }
    public bool hasNext(){
        if(index < bookShelf.getLength()){
            return true;
        }
        else{
            return false;
        }
    }
    public object next(){
        Book book = bookShelf.getBookAt(index);
        index++;
        return book;
    }
}