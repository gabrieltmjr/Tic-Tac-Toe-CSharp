namespace Tic_Tac_Toe
{
    public class Player
    {
        private string name;
        private char symbol;

        public Player(string name, char symbol)
        {
            this.name = name;
            this.symbol = symbol;
        }

        public Player()
        {
            this.name = "";
            this.symbol = ' ';
        }


        public string Name { get; set; }
        public char Symbol { get; set; }
    }
}