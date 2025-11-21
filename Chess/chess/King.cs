using board;

namespace chess {
    internal class King : Piece {
        public King(Color color, Board board) : base(color, board) {
        }
        public override string ToString() {
            return "R";
        }

        private bool CanMove(Position position) {
            Piece piece = board.Piece(position);
            return piece == null || piece.color != color;
        }

        public override bool[,] PossibleMoviments() {

            bool[,] mat = new bool[board.lines, board.column];
            Position pos = new Position(0, 0);


            int[,] directions = {
                {-1, 0}, {-1, 1}, {0, 1}, {1, 1},
                {1, 0}, {1, -1}, {0, -1}, {-1, -1}
            }; 

            for (int i = 0; i < directions.GetLength(0); i++) {
                pos.Values(
                    position.line + directions[i, 0],
                    position.column + directions[i, 1]
                );

                if (board.ValidPosition(pos) && CanMove(pos)) {
                    mat[pos.line, pos.column] = true;
                }
            }

            return mat;
        }

    }
}
