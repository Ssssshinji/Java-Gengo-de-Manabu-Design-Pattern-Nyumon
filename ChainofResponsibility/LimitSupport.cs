namespace ChainofResponsibility
{
    public class LimitSupport:Support
    {
        private int limit;
        public LimitSupport(string name, int limit):base(name){
            this.limit = limit;
        }
        protected override bool resolve(Trouble trouble){
            if(trouble.getNumber() < limit)return true;
            else return false;
        }
    }
}