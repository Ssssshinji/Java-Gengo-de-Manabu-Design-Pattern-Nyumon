namespace Flyweight
{
    public class BigString
    {
        private BigChar[] bigchars;
        public BigString(string str){
            initShared(str);
        }
        public BigString(string str, bool shared){
            if(shared == true){
                initShared(str);
            }
            else{
                initUnshared(str);
            }   
        }
        public void initShared(string str){
            bigchars = new BigChar[str.Length];
            BigCharFactory factory = BigCharFactory.getInstance();
            for(int i = 0; i < bigchars.Length; i++){
                bigchars[i] = factory.getBigChar(str[i]);
            }
        }
        public void initUnshared(string str){
            bigchars = new BigChar[str.Length];
            BigCharFactory factory = BigCharFactory.getInstance();
            for(int i = 0; i < bigchars.Length; i++){
                bigchars[i] = new BigChar(str[i]);
            }            
        }
        public void print(){
            for(int i =0; i < bigchars.Length; i++){
                bigchars[i].print();
            }
        }
    }
}