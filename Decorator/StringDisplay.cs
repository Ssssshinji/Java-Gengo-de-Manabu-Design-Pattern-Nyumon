using System.Text;
namespace Decorator
{
    public class StringDisplay : Display
    {
        private string str;
        public StringDisplay(string str)
        {
            this.str = str;
        }
        public override int getColumns(){
            return Encoding.UTF8.GetBytes(str).Length;
        }
        public override int getRows(){
            return 1;
        }
        public override string getRowText(int row){
            if(row == 0){
                return str;
            }
            else return null;
        }
    }
}