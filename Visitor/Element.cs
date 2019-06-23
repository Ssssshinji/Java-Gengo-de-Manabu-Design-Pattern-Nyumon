namespace Visitor
{
    public abstract class Element
    {
        public abstract void accept(Visitor v);
    }
}