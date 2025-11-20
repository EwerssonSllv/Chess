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

        public Piece Piece(int line, int column) {
            return pieces[line, column];
        }

        public Piece Piece(Position position) {
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

            ValidatePosition(position);

            return Piece(position) != null;

        }

        public Piece RemovePiece(Position position) {

            Piece aux = Piece(position);

            if (aux == null) {
                return null;
            }

            aux.position = null;
            pieces[position.line, position.column] = null;
            return aux;
        }


        public bool ValidPosition(Position position) {

            if (position.line < 0 || position.column < 0 || position.column > column || position.line > lines) {
                return false;
            }
            return true;
        }

        public void ValidatePosition(Position position) {
            if (!ValidPosition(position)){
                throw new BoardException("Invalid position");
            }
        }

    }
}
