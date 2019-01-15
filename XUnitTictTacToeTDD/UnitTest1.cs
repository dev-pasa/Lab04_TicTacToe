using System;
using Xunit;
using Lab04_TicTacToe.Classes;

namespace XUnitTictTacToeTDD
{
    public class UnitTest1
    {
        /// <summary>
        /// test for Column match 
        /// </summary>
        [Fact]
        public void ColumnMatch()
        {
            Player p1 = new Player();
            Player p2 = new Player();
            Game game = new Game(p1, p2);
            Board board = new Board();

            Position position1 = new Position(0, 0);
            Position position2 = new Position(0, 1);
            Position position3 = new Position(0, 2);

            game.Board.GameBoard[position1.Row, position1.Column] = "X";
            game.Board.GameBoard[position2.Row, position2.Column] = "X";
            game.Board.GameBoard[position3.Row, position3.Column] = "X";

            Assert.True(game.CheckForWinner(game.Board));
        }

        /// <summary>
        /// test for winner when diagonal match
        /// </summary>
        [Fact]
        public void DiagonalMatch()
        {
            Player p1 = new Player();
            Player p2 = new Player();
            Game game = new Game(p1, p2);
            Board board = new Board();

            Position position1 = new Position(0, 0);
            Position position2 = new Position(1, 1);
            Position position3 = new Position(2, 2);

            game.Board.GameBoard[position1.Row, position1.Column] = "O";
            game.Board.GameBoard[position2.Row, position2.Column] = "O";
            game.Board.GameBoard[position3.Row, position3.Column] = "O";

            Assert.True(game.CheckForWinner(game.Board));
        }

        /// <summary>
        /// test for Row match 
        /// </summary>
        [Fact]
        public void RowMatch()
        {
            Player p1 = new Player();
            Player p2 = new Player();
            Game game = new Game(p1, p2);
            Board board = new Board();

            Position position1 = new Position(0, 1);
            Position position2 = new Position(1, 1);
            Position position3 = new Position(2, 1);

            game.Board.GameBoard[position1.Row, position1.Column] = "X";
            game.Board.GameBoard[position2.Row, position2.Column] = "X";
            game.Board.GameBoard[position3.Row, position3.Column] = "X";

            Assert.True(game.CheckForWinner(game.Board));
        }

        /// <summary>
        /// Test that there is a switch in players 
        /// </summary>
        [Fact]
        public void Switch()
        {
            Player p1 = new Player();
            Player p2 = new Player();
            Game game = new Game(p1, p2);

            p1.IsTurn = true;
            game.SwitchPlayer();

            Assert.True(p2.IsTurn);
        }

        /// <summary>
        /// Confirm that the position the player inputs correlates to the correct index 
        /// </summary>
        [Fact]
        public void correlates()
        {
            Player p1 = new Player();
            Player p2 = new Player();
            Game game = new Game(p1, p2);

            Position position = new Position(2, 2);
            
            Assert.True(position.Row == 2 && position.Column == 2);
        }


        /// <summary>
        /// Confirm that the position the player inputs correlates to the correct index 
        /// </summary>
        [Fact]
        public void correlates2()
        {
            Player p1 = new Player();
            Player p2 = new Player();
            Game game = new Game(p1, p2);

            Position position = new Position(2, 2);
            Position gameSpot = Player.PositionForNumber(9);
            Assert.True(position.Row == gameSpot.Row && position.Column == gameSpot.Column);
        }
        
    }
}
