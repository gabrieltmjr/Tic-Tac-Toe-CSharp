using System;
using System.ComponentModel.DataAnnotations;

namespace Tic_Tac_Toe
{
    public class Menu
    {
        private Game newGame;
        
        public Menu() {}

        public void MainMenu() {
            sbyte option;
            Console.WriteLine("1. Instructions\n2. Play \n3. Exit");
            option = ValidMenuOption();
            switch (option)
            {
                case 1: Instructions();
                    break;
                case 2: Play();
                    break;
                case 3: Environment.Exit(0);
                    break;
                default: Environment.Exit(1);
                    break;
            }
        }

        private void Instructions()
        {
            Console.WriteLine("Just play the game boy!");
            MainMenu();
        }

        private void Play()
        {
            string player1Name, player2Name;
            player1Name = ValidName();
            player2Name = ValidName();
            newGame = new Game(player1Name, player2Name);
            newGame.Play();
            MainMenu();
        }

        private sbyte ValidMenuOption() {
            sbyte option = 0, menuMin = 1, menuMax = 3;
            bool pass = false;
            do
            {
                Console.WriteLine("Please input a menu option");
                try
                {
                    option = Convert.ToSByte(Console.ReadLine());
                    pass = true;
                }
                catch (FormatException i)
                {
                    Console.WriteLine(i.Message);
                }

                if (option < menuMin || option > menuMax) {
                    pass = false;
                    Console.WriteLine("Please input a number between "+menuMin+" and "+menuMax);
                }
                
            } while (!pass);

            return option;
        }

        private string ValidName() {
            string name;
            do
            {
                Console.WriteLine("Please type in your name (max 15 characters)");
                name = Console.ReadLine();
                if (name.Length > 15)
                {
                    Console.WriteLine("Error!");
                }

            } while (name.Length > 15);

            return name;
        }
    }
}