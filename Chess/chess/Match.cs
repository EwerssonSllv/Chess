using board;
using Chess;
using System;
namespace chess {
    internal class Match {
        public Board board {
            get; set;
        }
        private int turn;
        private Color player;
        public bool ending {
            get; private set;
        }

        public Match() {
            board = new Board(8, 8);
            turn = 1;
            player = Color.WHITE;
            PlacePieces();
            ending = false;
        }

        public void Move(Position origin, Position destiny) {
            Piece piece = board.RemovePiece(origin);
            piece.updateNumOfMoves();
            Piece capturedPiece = board.RemovePiece(destiny);
            board.Place(piece, destiny);
        }

        private void PlacePieces() {

            board.Place(new Tower(Color.WHITE, board), new ChessPosition(1, 'a').ToPosition());
            board.Place(new Tower(Color.WHITE, board), new ChessPosition(1, 'h').ToPosition());
            board.Place(new King(Color.WHITE, board), new ChessPosition(1, 'e').ToPosition());


            board.Place(new Tower(Color.BLACK, board), new ChessPosition(8, 'a').ToPosition());
            board.Place(new Tower(Color.BLACK, board), new ChessPosition(8, 'h').ToPosition());
            board.Place(new King(Color.BLACK, board), new ChessPosition(8, 'e').ToPosition());

        }

    }
}
