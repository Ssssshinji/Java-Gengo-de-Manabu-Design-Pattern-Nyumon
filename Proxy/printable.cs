namespace Proxy
{
    public interface printable
    {
        void setPrinterName(string name);
        string getPrinterName();
        void Print(string str);
    }
}