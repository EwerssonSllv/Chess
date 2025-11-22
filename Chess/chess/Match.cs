using board;
using Chess;
using System;
namespace chess {
    internal class Match {
        public Board board {
            get; set;
        }
        public int turn {
            get; private set;
        }

        public Color player {
            get; private set;
        }
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
            piece.UpdateNumOfMoves();
            Piece capturedPiece = board.RemovePiece(destiny);
            board.Place(piece, destiny);
        }

        private void SwitchPlayer() {

            if(player == Color.WHITE){
                player = Color.BLACK;
            } else {
                player = Color.WHITE;
            }
        }

        public void RealizeMove(Position origin, Position destiny) {
            Move(origin, destiny);
            turn++;
            SwitchPlayer();
        }

        public void ValidateOriginPosition(Position position) {

            if(board.Piece(position) == null) {
                throw new BoardException("There is no piece in that position.");
            }

            if (player != board.Piece(position).color) {
                throw new BoardException("The chosen piece is not yours.");
            }

            if (!board.Piece(position).MovimentIsPossible()) {
                throw new BoardException("There are no possible moves for the chosen piece.");
            }

        }

        public void ValidateDestinyPosition(Position origin, Position destiny) {

            if (!board.Piece(origin).CanMoveFor(destiny)) {
                throw new BoardException("Invalid destination position");
            }

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
