namespace board {
    internal class Board {
        public int lines {
            get; set;
        }

        public int column { get; set; }

        private Piece[,] pieces;

        public Board(int lines, int column) {
            this.lines = lines;
            this.column = column;
            pieces = new Piece[lines, column];
        }
    }
}
