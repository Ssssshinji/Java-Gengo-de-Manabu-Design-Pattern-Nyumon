namespace Strategy
{
    public interface Strategy
    {
         Hand nextHand();
         void study(bool win);
    }
}