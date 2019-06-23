namespace Bridge
{
    public class Display
    {
        private DisplayImpl impl;
        public Display(DisplayImpl impl){
            this.impl = impl;
        }

        public void open(){
            this.impl.rawopen();
        }
        public void print(){
            this.impl.rawprint();
        }
        public void close(){
            this.impl.rawclose();
        }
        public void display(){
            this.open();
            this.print();
            this.close();
        }
    }
}