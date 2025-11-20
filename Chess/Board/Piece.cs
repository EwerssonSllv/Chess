namespace board {
    internal class Piece {
        public Position position {
            get; set;
        }
        public Color color {
            get; protected set;
        }
        public int numOfMoves {
            get; protected set;
        }

        public Board board {
            get; protected set;
        }

        public Piece(Position position, Color color, int numOfMoves, Board board) {
            this.position = position;
            this.color = color;
            this.numOfMoves = 0;
            this.board = board;
        }



    }
}
