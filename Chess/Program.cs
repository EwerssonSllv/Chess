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

                    Console.Write("Origin: ");
                    Position origin = Screen.ReadChessPosition().ToPosition();
                    Console.Write("Destiny: ");
                    Position destiny = Screen.ReadChessPosition().ToPosition();


                    match.Move(origin, destiny);
                }

            } catch(BoardException e) {
                Console.WriteLine(e.Message);
            }

        }
    }

}