using System.Collections.Generic;
namespace Flyweight
{
    public class BigCharFactory
    {
        private Dictionary<string, BigChar> pool = new Dictionary<string, BigChar>();
        private static BigCharFactory singleton = new BigCharFactory();
        private BigCharFactory(){

        }
        public static BigCharFactory getInstance(){
            return singleton;
        }
        public BigChar getBigChar(char charname){
            bool bl = pool.ContainsKey("" + charname);
            if(bl == false){
                BigChar bc = new BigChar(charname);
                pool.Add("" + charname, bc);
                return bc;
            }
            else
            {
                BigChar bc = pool["" + charname];
                return bc;
            }
            
        }
    }
}