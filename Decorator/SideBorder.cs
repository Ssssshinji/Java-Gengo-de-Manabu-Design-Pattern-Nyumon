namespace Decorator
{
    public class SideBorder : Border
    {
        private char borderChar;
        public SideBorder(Display display, char borderChar):base(display)
        {  
            this.borderChar = borderChar;
        }
        public override int getColumns(){
            return 1 + display.getColumns() + 1;
        }
        public override int getRows(){
            return display.getRows();
        }
        public override string getRowText(int row){
            return borderChar + display.getRowText(row) + borderChar;
        }
    }
}