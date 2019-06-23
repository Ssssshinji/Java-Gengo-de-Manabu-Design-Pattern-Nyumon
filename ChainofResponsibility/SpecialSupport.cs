namespace ChainofResponsibility
{
    public class SpecialSupport:Support
    {
        private int number;
        public SpecialSupport(string name, int number):base(name){
            this.number = number;
        }
        protected override bool resolve(Trouble trouble){
            if(trouble.getNumber() == number){
                return true;
            }
            else return false;
        }
    }
}