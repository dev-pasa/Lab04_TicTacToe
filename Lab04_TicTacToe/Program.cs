using System;
using Lab04_TicTacToe.Classes;

namespace Lab04_TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's play the Tic Tac Toe game!");

            //method call
            StartGame();
        }


        public static void StartGame()
        {
            Console.WriteLine("First Player will need to enter the name.");
            Console.Write("Player one, enter your name: ");
            string playerOneName = Console.ReadLine();

            Player playerOne = new Player
            {
                Name = playerOneName,
                Marker = "X",
                IsTurn = true
            };

            Console.WriteLine();
            Console.WriteLine("Second Player will need to enter the name.");
            Console.Write("Player two, enter your name: ");
            string playerTwoName = Console.ReadLine();

            Player playerTwo = new Player
            {
                Name = playerTwoName,
                Marker = "O",
                IsTurn = true
            };

            //create a new game here
            Game newGame = new Game(playerOne, playerTwo);

            //create a default player and have him play the game. 
            Player winner = newGame.Play();
            
            if(winner != null)
            {
                Console.WriteLine($"The winner of the game is {winner.Name}");
                Console.WriteLine("Press any key to restart the game");
                Console.ReadLine();
                StartGame();
            }
            else
            {
                Console.WriteLine( "Looks like we have a draw!");
                Console.WriteLine("Press any key to restart the game");
                Console.ReadLine();
                StartGame();
            }
        }
    }
}
