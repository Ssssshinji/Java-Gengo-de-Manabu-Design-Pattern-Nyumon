namespace Builder
{
    public interface Builder
    {
         void makeTitle(string title);
         void makeString(string str);
         void makeItems(string[] items);
         void close();
    }
}