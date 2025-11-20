namespace board {
    internal class Board {
        public int lines {
            get; set;
        }

        public int column {
            get; set;
        }

        private Piece[,] pieces;

        public Board(int lines, int column) {
            this.lines = lines;
            this.column = column;
            pieces = new Piece[lines, column];
        }

        public Piece piece(int line, int column) {
            return pieces[line, column];    
        }

        public void Place(Piece p, Position pos) {
            pieces[pos.line, pos.column] = p;
            p.position = pos;
        }

    }
}
