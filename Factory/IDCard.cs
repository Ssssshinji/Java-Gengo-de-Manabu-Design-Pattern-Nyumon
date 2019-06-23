using System;
namespace Factory
{
    public class IDCard : Product
    {
        private string owner;
        private string serial;
        public IDCard(string owner, string serial){
            this.owner = owner;
            this.serial = serial;
            Console.WriteLine("制作了" + this.owner + '('+ this.serial + ')'+ "的ID卡");
        }
        public override void use(){
            Console.WriteLine("制作了" + this.owner + '('+ this.serial + ')'+ "的ID卡");
        }
        public string getOwner(){
            return this.owner;
        }
        public string getSerial(){
            return this.serial;
        }
    }
}