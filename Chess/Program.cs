using System;
using board;
using chess;

namespace Chess {

    class Program {
        static void Main(string[] args) {

            try {

                Match match = new Match();


                while (!match.ending) {

                    try {
                        Console.Clear();
                        Screen.PrintBoard(match.board);
                        Console.WriteLine();
                        Console.WriteLine("Turn: " + match.turn);
                        Console.WriteLine("Awaiting player: " + match.player);

                        Console.WriteLine();
                        Console.Write("Origin: ");
                        Position origin = Screen.ReadChessPosition().ToPosition();
                        match.ValidateOriginPosition(origin);

                        bool[,] pmoves = match.board.Piece(origin).PossibleMoviments();

                        Console.Clear();
                        Screen.PrintBoard(match.board, pmoves);
                        Console.WriteLine();
                        Console.Write("Destiny: ");
                        Position destiny = Screen.ReadChessPosition().ToPosition();
                        match.ValidateDestinyPosition(origin, destiny);

                        match.RealizeMove(origin, destiny);
                    } catch (BoardException e) {

                        Console.WriteLine(e.Message);
                        Console.ReadLine();
                    
                    }
                }


            } catch (BoardException e) {
                Console.WriteLine(e.Message);
            }

        }
    }

}