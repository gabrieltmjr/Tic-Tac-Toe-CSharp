using System;

namespace Tic_Tac_Toe
{
    public class Game : Board
    {
        private readonly Player player1, player2;
        public Game(string player1Name, string player2Name)
        {
            player1 = new Player();
            player2 = new Player();
            player1.Name = player1Name;
            player1.Symbol = 'X';
            player2.Name = player2Name;
            player2.Symbol = 'O';
        }

        public void Play()
        {
            sbyte playerTurn = 0;
            string firstPlayer, winner = "";
            sbyte movePosition;
            bool testPlayerPlacement = false;
            Console.WriteLine("Okay! " + player1.Name + " symbol is " + player1.Symbol + " and " +
                              player2.Name + " symbol is " + player2.Symbol);
            Console.WriteLine("Who will play first? (X or O) ");
            firstPlayer = Console.ReadLine();
            switch (firstPlayer)
            {
                case "X" : case "x" : break;
                case "O" : case "o" : playerTurn = 1; break;
                default: Console.WriteLine("I did not understand that so "+player1.Name+" will play first");
                    break;
            }
                
            while (true)
            {
                PrintBoard();
                if (playerTurn == 0)
                {
                    do
                    {
                        Console.WriteLine(player1.Name + " make your move! ");
                        movePosition = Convert.ToSByte(Console.ReadLine());
                        testPlayerPlacement = PlaceSymbol(player1.Symbol, movePosition);
                        if (!testPlayerPlacement)
                        {
                            Console.WriteLine("Invalid move!");
                        }
                    } while (!testPlayerPlacement);

                    
                    //Conditions for the end of the game
                    if (CheckWinner(player1.Symbol)) {
                        PrintBoard();
                        winner = player1.Name;
                        break;
                    }  
                    
                    if (CheckDraw()) { break; }
                    //ends here
                    
                    playerTurn++;
                } else if (playerTurn == 1) {
                    do
                    {
                        Console.WriteLine(player2.Name + " make your move! ");
                        movePosition = Convert.ToSByte(Console.ReadLine());
                        testPlayerPlacement = PlaceSymbol(player2.Symbol, movePosition);
                        if (!testPlayerPlacement)
                        {
                            Console.WriteLine("Invalid move!");
                        }
                    } while (!testPlayerPlacement);

                    if (CheckWinner(player2.Symbol)) {
                        PrintBoard();
                        winner = player2.Name;
                        break;
                    }
                    
                    if (CheckDraw()) { break; }
                    
                    playerTurn--;
                }

            }

            if (winner == "")
            {
                Console.WriteLine("IT'S A DRAW!");
            }
            else
            {
                Console.WriteLine("The winner is "+winner+"!!!");
            }
            
        }
        
        
    }
}