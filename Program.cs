using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pg_chess.Chess;

namespace pg_chess
{
    class Program
    {
        static void Header()
        {
            Console.WriteLine("#######################################################");
            Console.WriteLine("##                  Laboratorium nr1                 ##");
            Console.WriteLine("#######################################################");
            Console.WriteLine();
        }
        
        static void Main(string[] args)
        {
            //Writing header
            Header();

            //Making figures
            Figure figure1 = new Pawn();
            figure1.Color = ChessColor.Black;
            figure1.Position = new Position(1,4);

            Figure figure2 = new Pawn();
            figure2.Color = ChessColor.White;
            figure2.Position = new Position(3, 4);

            Figure figure3 = new King();
            figure3.Color = ChessColor.Black;
            figure3.Position = new Position(5, 4);

            Figure figure4 = new Bishop();
            figure4.Color = ChessColor.White;
            figure4.Position = new Position(5, 5);

            Figure figure5 = new Castle();
            figure5.Color = ChessColor.White;
            figure5.Position = new Position(3, 7);

            //Figures to string
            Console.WriteLine(figure1);
            Console.WriteLine(figure2);
            Console.WriteLine(figure3);
            Console.WriteLine(figure4);
            Console.WriteLine(figure5);

            //Checking movement
            Console.WriteLine("Figure1 can move " + figure1.CanMove(new Position(figure1.Position.X, figure1.Position.Y + 1)));
            Console.WriteLine("Figure1 can move " + figure1.CanMove(new Position(figure1.Position.X, figure1.Position.Y - 1)));

            Console.WriteLine("Figure2 can move " + figure2.CanMove(new Position(figure2.Position.X, figure2.Position.Y + 1)));
            Console.WriteLine("Figure2 can move " + figure2.CanMove(new Position(figure2.Position.X, figure2.Position.Y - 1)));

            Console.WriteLine("Figure3 can move " + figure3.CanMove(new Position(figure3.Position.X + 1, figure3.Position.Y + 1)));
            Console.WriteLine("Figure3 can move " + figure3.CanMove(new Position(figure3.Position.X, figure3.Position.Y - 2)));

            Console.WriteLine("Figure4 can move " + figure4.CanMove(new Position(figure4.Position.X + 1, figure4.Position.Y + 1)));
            Console.WriteLine("Figure4 can move " + figure4.CanMove(new Position(figure4.Position.X + 1, figure4.Position.Y + 2)));

            Console.WriteLine("Figure5 can move " + figure5.CanMove(new Position(figure5.Position.X, figure5.Position.Y - 1)));
            Console.WriteLine("Figure5 can move " + figure5.CanMove(new Position(figure5.Position.X - 1, figure5.Position.Y - 1)));

            //Reading Key
            Console.ReadKey();
        }
    }
}
