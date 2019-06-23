namespace Strategy
{
    public class Player
    {
        private string name;
        private Strategy strategy;
        private int wincount;
        private int losecount = 0;
        private int gamecount = 0;
        public Player(string name, Strategy strategy){
            this.name = name;
            this.strategy = strategy;
        }
        public Hand nextHand(){
            return this.strategy.nextHand();
        }
        public void win(){
            strategy.study(true);
            wincount++;
            gamecount++;
        }
        public void lose(){
            strategy.study(false);
            losecount++;
            gamecount++;
        }
        public void even(){
            gamecount++;
        }
        public string toString(){
            return "[" + name + ":" + gamecount + "games," + wincount + "win," + losecount + "lose" + "]";
        }
    }
}