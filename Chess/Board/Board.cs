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

        public Piece piece(Position position) {
            return pieces[position.line, position.column];
        }

        public void Place(Piece p, Position pos) {

            if (hasPiece(pos)) {
                throw new BoardException("There is already a piece in this position.");
            }
                pieces[pos.line, pos.column] = p;
                p.position = pos;
            
        }

        public bool hasPiece(Position position) {

            validatePosition(position);

            return piece(position) != null;

        }

        public bool validPosition(Position position) {

            if (position.line < 0 || position.column < 0 || position.column > column || position.line > lines) {
                return false;
            }
            return true;
        }

        public void validatePosition(Position position) {
            if (!validPosition(position)){
                throw new BoardException("Invalid position");
            }
        }

    }
}
