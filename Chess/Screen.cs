using board;
using chess;

namespace Chess {
    internal class Screen {

        public static void PrintBoard(Board board) {

            for (int i = 0; i < board.lines; i++) {
                Console.Write(8 - i + " ");
                for (int j = 0; j < board.column; j++) {
                    PrintPiece(board.Piece(i, j));
                }
                Console.WriteLine();
            }
            Console.WriteLine("  a b c d e f g h");
        }


        public static void PrintBoard(Board board, bool[,] pmoves ) {

            ConsoleColor background = Console.BackgroundColor;
            ConsoleColor backgroundA = ConsoleColor.DarkGray;

            for (int i = 0; i < board.lines; i++) {
                Console.Write(8 - i + " ");
                for (int j = 0; j < board.column; j++) {

                    if (pmoves[i, j]) {
                        Console.BackgroundColor = backgroundA;
                    } else {
                        Console.BackgroundColor = background;
                    }

                    PrintPiece(board.Piece(i, j));
                    Console.BackgroundColor = background;

                }

                Console.WriteLine();
            }

            Console.WriteLine("  a b c d e f g h");
            Console.BackgroundColor = background;
        }

        public static void PrintPiece(Piece piece) {

            if (piece == null) {
                Console.Write("- ");
                return;
            }

            if (piece.color == Color.WHITE) {
                Console.Write(piece + " ");
            } else {
                ConsoleColor aux = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(piece + " ");
                Console.ForegroundColor = aux;
            }
        }



        public static ChessPosition ReadChessPosition() {

            string s = Console.ReadLine();

            char column = s[0];
            int line = int.Parse(s[1] + "");

            return new ChessPosition(line, column);
        
        }
    }
}
