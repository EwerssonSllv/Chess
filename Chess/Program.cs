using System;
using board;
using chess;

namespace Chess {

    class Program {
        static void Main(string[] args) {

            try {

                Match match = new Match();


                while (!match.ending) {

                    Console.Clear();
                    Screen.PrintBoard(match.board); 

                    Console.WriteLine();
                    Console.Write("Origin: ");
                    Position origin = Screen.ReadChessPosition().ToPosition();

                    bool[,] pmoves = match.board.Piece(origin).PossibleMoviments();

                    Console.Clear();
                    Screen.PrintBoard(match.board, pmoves); 
                    Console.WriteLine();
                    Console.Write("Destiny: ");
                    Position destiny = Screen.ReadChessPosition().ToPosition();

                    match.Move(origin, destiny);
                }


            } catch (BoardException e) {
                Console.WriteLine(e.Message);
            }

        }
    }

}