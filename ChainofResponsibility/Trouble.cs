namespace ChainofResponsibility
{
    public class Trouble
    {
        private int number;
        public Trouble(int number){
            this.number = number;
        }
        public int getNumber(){
            return number;
        }
        public override string ToString(){
            return "[Trouble" + number +"]";
        }
    }
}