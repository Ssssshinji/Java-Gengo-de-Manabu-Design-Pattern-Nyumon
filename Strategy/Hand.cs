namespace Strategy
{
    //涉及到了单例模式
    
    
    
        public class Hand
    {
        public static int SHITOU = 0;
        public static int JIANDAO = 1;
        public static  int BU = 3;
        public static Hand[] hand = {
            new Hand(SHITOU),
            new Hand(JIANDAO),
            new Hand(BU)
        };
        private static string[] value = {
            "石头","剪刀","布"
        };
        private int handvalue;
        private Hand(int handvalue){
            this.handvalue = handvalue;
        }
        //根据枚举获取对应实例
        public static Hand getHand(int handvalue){
            return hand[handvalue];
        }
        public bool isStrongerThan(Hand h){
            return fight(h) == 1;
        }
        private int fight(Hand h){
            if(this == h){
                return 0;
            }
            else if((this.handvalue + 1) % 3 == h.handvalue){
                return 1;
            }
            else{
                return -1;
            }
        }
        public string toString(){
            return value[handvalue];
        }
    }
}