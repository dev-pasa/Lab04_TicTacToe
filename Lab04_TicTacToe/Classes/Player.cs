﻿using System;
using System.Collections.Generic;
using System.Text;
using Lab04_TicTacToe.Classes;

namespace Lab04_TicTacToe.Classes
{
    public class Player
    {
        /// <summary>
        /// set the name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// set the marker
        /// </summary>
        public string Marker { get; set; }

        /// <summary>
        /// check for user's turn
        /// </summary>
        public bool IsTurn { get; set; }


        public Position GetPosition(Board board)
        {
            Position desiredCoordinate = null;
            while (desiredCoordinate is null)
            {
                Console.WriteLine("Please select a location");
                Int32.TryParse(Console.ReadLine(), out int position);
                desiredCoordinate = PositionForNumber(position);
            }
            return desiredCoordinate;
        }

        /// <summary>
        /// If the user inputs a number, it will replace that number with and X or O
        /// </summary>
        /// <param name="position"></param>
        /// <returns></returns>
        public static Position PositionForNumber(int position)
        {
            switch (position)
            {
                case 1: return new Position(0, 0); // Top Left
                case 2: return new Position(0, 1); // Top Middle
                case 3: return new Position(0, 2); // Top Right
                case 4: return new Position(1, 0); // Middle Left
                case 5: return new Position(1, 1); // Middle Middle
                case 6: return new Position(1, 2); // Middle Right
                case 7: return new Position(2, 0); // Bottom Left
                case 8: return new Position(2, 1); // Bottom Middle 
                case 9: return new Position(2, 2); // Bottom Right

                default: return null;
            }
        }

        /// <summary>
        /// Take turn for each player
        /// </summary>
        /// <param name="board"></param>
        public bool TakeTurn(Board board)
        {
            IsTurn = true;

            Console.WriteLine($"Select a number from the board {Name}.");

            Position position = GetPosition(board);

             if (Int32.TryParse(board.GameBoard[position.Row, position.Column], out int _))
                {
                    board.GameBoard[position.Row, position.Column] = Marker;
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}