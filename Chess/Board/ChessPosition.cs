namespace board {
    internal class ChessPosition {

        public char column {
            get; set;
        }

        public int line {
            get; set;
        }

        public ChessPosition(int line, char column) {
            this.column = column;
            this.line = line;
        }

        public Position ToPosition() {
            return new Position(8 - line, column - 'a');
        }

        public override string ToString() {
            return "" + column + line;
        }

    }
}
