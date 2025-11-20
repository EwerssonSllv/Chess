using System;
using board;
using chess;

namespace Chess {

    class Program {
        static void Main(string[] args) {

            Board board = new Board(8, 8);

            board.Place(new Tower(Color.BLACK, board), new Position(0, 0));
            board.Place(new Tower(Color.BLACK, board), new Position(2, 3));
            board.Place(new King(Color.BLACK, board), new Position(3, 4));

            Screen.printBoard(board);


            Console.ReadLine();

        }
    }

}