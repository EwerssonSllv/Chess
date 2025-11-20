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

        public Piece(Color color, Board board) {
            this.position = null;
            this.color = color;
            this.numOfMoves = 0;
            this.board = board;
        }

        public void updateNumOfMoves() {
            numOfMoves++;
        }


    }
}
