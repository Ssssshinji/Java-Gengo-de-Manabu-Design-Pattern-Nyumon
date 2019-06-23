namespace ChainofResponsibility
{
    public class NoSupport:Support
    {
        public NoSupport(string name) :base(name){

        }
        protected override bool resolve(Trouble trouble){
            return false;
        }
    }
}