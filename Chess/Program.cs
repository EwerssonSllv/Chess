using System;
using board;
using chess;

namespace Chess {

    class Program {
        static void Main(string[] args) {

            ChessPosition chessPosition = new ChessPosition('a', 1);

            Console.WriteLine(chessPosition.toPosition());
            Console.ReadLine();

        }
    }

}