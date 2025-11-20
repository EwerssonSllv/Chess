using board;

namespace Chess {
    internal class Screen {

        public static void printBoard(Board board) {

            for (int i = 0; i < board.lines; i++) {
                Console.Write(8 - i + " ");
                for (int j = 0; j < board.column; j++) {
                    if (board.piece(i, j) == null) {
                        Console.Write("- ");
                    } else {
                        PrintPiece(board.piece(i, j));
                        Console.Write(' ');
                    }

                }

                Console.WriteLine();
            }

            Console.Write("  a b c d e f g h");
        }

        public static void PrintPiece(Piece piece) {

            if (piece.color == Color.WHITE) {
                Console.Write(piece);
            } else {
                ConsoleColor aux = Console.ForegroundColor;

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(piece);
                Console.ForegroundColor = aux;
            }

        }
    }
}
