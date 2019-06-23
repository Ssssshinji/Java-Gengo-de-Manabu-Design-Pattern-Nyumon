namespace ChainofResponsibility
{
    public class OddSupport:Support
    {
        public OddSupport(string name) :base(name){
            
        }
        protected override bool resolve(Trouble trouble){
            if(trouble.getNumber() % 2 == 1){
                return true;
            }
            else return false;
        }
    }
}