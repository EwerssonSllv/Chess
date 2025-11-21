using board;
using System.ComponentModel.DataAnnotations;

namespace chess {
    internal class Tower : Piece {
        public Tower(Color color, Board board) : base(color, board) {
        }

        public override string ToString() {
            return "T";
        }

        private bool CanMove(Position position) {
            Piece piece = board.Piece(position);
            return piece == null || piece.color != color;
        }

        public override bool[,] PossibleMoviments() {

            bool[,] mat = new bool[board.lines, board.column];

            Position pos = new Position(0, 0);

            // ABOVE
            pos.Values(position.line - 1, position.column);
            while (board.ValidPosition(pos) && CanMove(pos)) {
                mat[pos.line, pos.column] = true;
                if (board.Piece(pos) != null && board.Piece(pos).color != color) break;
                pos.line--;
            }

            // BELOW
            pos.Values(position.line + 1, position.column);
            while (board.ValidPosition(pos) && CanMove(pos)) {
                mat[pos.line, pos.column] = true;
                if (board.Piece(pos) != null && board.Piece(pos).color != color) break;
                pos.line++;
            }

            // RIGHT
            pos.Values(position.line, position.column + 1);
            while (board.ValidPosition(pos) && CanMove(pos)) {
                mat[pos.line, pos.column] = true;
                if (board.Piece(pos) != null && board.Piece(pos).color != color) break;
                pos.column++;
            }

            // LEFT
            pos.Values(position.line, position.column - 1);
            while (board.ValidPosition(pos) && CanMove(pos)) {
                mat[pos.line, pos.column] = true;
                if (board.Piece(pos) != null && board.Piece(pos).color != color) break;
                pos.column--;
            }

            return mat;
        }

    }
}
