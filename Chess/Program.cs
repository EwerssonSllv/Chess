using System;
using board;
using chess;

namespace Chess {

    class Program {
        static void Main(string[] args) {

            try {

                Board board = new Board(8, 8);

                board.Place(new Tower(Color.BLACK, board), new Position(0, 0));
                board.Place(new Tower(Color.BLACK, board), new Position(2, 9));
                board.Place(new King(Color.BLACK, board), new Position(0, 2));

                Screen.printBoard(board);

            } catch (BoardException e) {

                Console.WriteLine(e.Message);

            }


        }
    }

}