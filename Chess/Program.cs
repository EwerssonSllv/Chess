using System;
using board;
using chess;

namespace Chess {

    class Program {
        static void Main(string[] args) {

            try {

                Board board = new Board(8, 8);

                board.Place(new Tower(Color.BLACK, board), new Position(0, 1));
                board.Place(new Tower(Color.BLACK, board), new Position(1, 3));
                board.Place(new King(Color.BLACK, board), new Position(0, 2));

                board.Place(new Tower(Color.WHITE, board), new Position(2, 1));
                board.Place(new Tower(Color.WHITE, board), new Position(5, 3));
                board.Place(new King(Color.WHITE, board), new Position(2, 2));

                Screen.printBoard(board);

            } catch(BoardException e) {
                Console.WriteLine(e.Message);
            }

        }
    }

}