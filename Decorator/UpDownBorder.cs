using System.Text;
namespace Decorator
{
    public class UpDownBorder : Border
    {
        private char ch;
        public UpDownBorder(Display display,char ch) : base(display)
        {
            this.ch = ch;
        }
        public override int getColumns(){
            return display.getColumns();
        }
        public override int getRows(){
            return 1 + display.getRows() + 1;
        }
        private string makeLine(char ch, int count){
            StringBuilder builder = new StringBuilder();
            for(int i =0; i < count; i++){
                builder.Append(ch);
            }
            return builder.ToString();
        }
        public override string getRowText(int row){
            if(row==0){
                return makeLine(ch, display.getColumns());
            }
            else if(row == display.getRows() + 1){
                return makeLine(ch, display.getColumns());
            }
            else
            {
                return display.getRowText(row - 1);
            }
        }
    }
}