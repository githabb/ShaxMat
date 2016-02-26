using ShaxMat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //Test();

            //PlayGame();
            Pawn whitePawn1 = new Pawn(FigureColor.White, FieldLetter.c, 3);
            Console.WriteLine(whitePawn1.InfoFigure());

            FieldLetter xod = FieldLetter.c;
            byte nomer = 4;
            bool canMovePawn = whitePawn1.CanMove(xod, nomer);
            Console.WriteLine("Пешка с поля {0}{1} может ходить на поле {2}{3} : {4}", whitePawn1.Letter, whitePawn1.Number, xod, nomer, canMovePawn);


            Pawn blackPawn1 = new Pawn(FigureColor.Black, FieldLetter.c, 5);
            Console.WriteLine(blackPawn1.InfoFigure());

            FieldLetter xodblack = FieldLetter.c;
            byte nomerblack = 4;
            bool canMoveBlackPawn = blackPawn1.CanMove(xodblack, nomerblack);
            Console.WriteLine("Пешка с поля {0}{1} может ходить на поле {2}{3} : {4}", blackPawn1.Letter, blackPawn1.Number, xodblack, nomerblack, canMoveBlackPawn);


            Rook whiteRook1 = new Rook(FigureColor.White, FieldLetter.a, 5);
            Console.WriteLine(whiteRook1.InfoFigure());

            FieldLetter xodRookWhiteLeft = FieldLetter.c;
            byte nomerRookWhiteLeft = 3;
            bool canMoveRook = whiteRook1.CanMove(xodRookWhiteLeft, nomerRookWhiteLeft);
            Console.WriteLine("Белая Ладья с поля {0}{1} может ходить на поле {2}{3} : {4}", whiteRook1.Letter, whiteRook1.Number, xodRookWhiteLeft, nomerRookWhiteLeft, canMoveRook);


            Bishop whiteBishop1 = new Bishop(FigureColor.White, FieldLetter.c, 6);
            Console.WriteLine(whiteRook1.InfoFigure());

            FieldLetter xodBishopWhiteLeft = FieldLetter.d;
            byte nomerBishopWhiteLeft = 5;
            bool canMoveBishop = whiteBishop1.CanMove(xodBishopWhiteLeft, nomerBishopWhiteLeft);
            Console.WriteLine("Белый Слон с поля {0}{1} может ходить на поле {2}{3} : {4}", whiteBishop1.Letter, whiteBishop1.Number, xodBishopWhiteLeft, nomerBishopWhiteLeft, canMoveBishop);


            Queen whiteQueen1 = new Queen(FigureColor.White, FieldLetter.b, 7);
            Console.WriteLine(whiteQueen1.InfoFigure());

            FieldLetter xodQueenWhiteLeft = FieldLetter.a;
            byte nomerQueenWhiteLeft = 6;
            bool canMoveQueen = whiteQueen1.CanMove(xodQueenWhiteLeft, nomerQueenWhiteLeft);
            Console.WriteLine("Белый Ферзь с поля {0}{1} может ходить на поле {2}{3} : {4}", whiteQueen1.Letter, whiteQueen1.Number, xodQueenWhiteLeft, nomerQueenWhiteLeft, canMoveQueen);


            King whiteKing1 = new King(FigureColor.White, FieldLetter.e, 4);
            Console.WriteLine(whiteKing1.InfoFigure());

            FieldLetter xodKingWhiteLeft = FieldLetter.d;
            byte nomerKingWhiteLeft = 4;
            bool canMoveKing = whiteKing1.CanMove(xodKingWhiteLeft, nomerKingWhiteLeft);
            Console.WriteLine("Белый Король с поля {0}{1} может ходить на поле {2}{3} : {4}", whiteKing1.Letter, whiteKing1.Number, xodKingWhiteLeft, nomerKingWhiteLeft, canMoveKing);



        
            Console.ReadLine();
        }

        private static void Test()
        {
            Rook rook1 = new Rook(FigureColor.White, FieldLetter.a, 1);
            string infoRook1 = rook1.InfoFigure();
            Console.WriteLine(infoRook1);

            Rook rook2 = new Rook(FigureColor.White, FieldLetter.h, 1);
            string infoRook2 = rook2.InfoFigure();
            Console.WriteLine(infoRook2);

            Knight knight1 = new Knight(FigureColor.White, FieldLetter.b, 1);
            string infoKnight1 = knight1.InfoFigure();
            Console.WriteLine(infoKnight1);




            // создаем белого Коня на g1
            Knight knight2 = new Knight(FigureColor.White, FieldLetter.g, 1);

            // выводим информацию о Коня на экран
            string infoKnight2 = knight2.InfoFigure();
            Console.WriteLine("Белый Конь: " + infoKnight2);

            // конь ходит на h3
            string knight2AfterMove = knight2.Move(FieldLetter.h, 3);
            Console.WriteLine("Слон делает ход: " + knight2AfterMove);

            // выводим информацию о пешке на экран (где она находится после хода)

            string infoKnight2AfterMove = knight2.InfoFigure();
            Console.WriteLine("Белый Конь после хода: " + infoKnight2AfterMove);




            Bishop bishop2 = new Bishop(FigureColor.Black, FieldLetter.f, 1);
            string infoBishop2 = bishop2.InfoFigure();
            Console.WriteLine(infoBishop2);

            // создаем белого Слона на c1
            Bishop bishop1 = new Bishop(FigureColor.White, FieldLetter.c, 1);

            // выводим информацию о пешке на экран
            string infoBishop1 = bishop1.InfoFigure();
            Console.WriteLine("Белый Слон: " + infoBishop1);

            // слон ходит на e3

            string bishopAfterMove = bishop1.Move(FieldLetter.e, 3);
            Console.WriteLine("Слон делает ход: " + bishopAfterMove);

            // выводим информацию о пешке на экран (где она находится после хода)

            string infoBishopAfterMove = bishop1.InfoFigure();
            Console.WriteLine("Белый слон после хода: " + infoBishopAfterMove);




            King king = new King(FigureColor.White, FieldLetter.d, 1);
            string infoKing = king.InfoFigure();
            Console.WriteLine(infoKing);


            Queen queen = new Queen(FigureColor.White, FieldLetter.e, 1);
            string infoQueen = queen.InfoFigure();
            Console.WriteLine(infoQueen);


            Pawn pawn1 = new Pawn(FigureColor.White, FieldLetter.a, 2);
            string infoPawn1 = pawn1.InfoFigure();
            Console.WriteLine(infoPawn1);

            Pawn pawn2 = new Pawn(FigureColor.White, FieldLetter.b, 2);
            string infoPawn2 = pawn2.InfoFigure();
            Console.WriteLine(infoPawn2);

            Pawn pawn3 = new Pawn(FigureColor.White, FieldLetter.c, 2);
            string infoPawn3 = pawn3.InfoFigure();
            Console.WriteLine(infoPawn3);

            Pawn pawn4 = new Pawn(FigureColor.White, FieldLetter.d, 2);
            string infoPawn4 = pawn4.InfoFigure();
            Console.WriteLine(infoPawn4);

            Pawn pawn5 = new Pawn(FigureColor.White, FieldLetter.e, 2);
            string infoPawn5 = pawn5.InfoFigure();
            Console.WriteLine(infoPawn5);

            Pawn pawn6 = new Pawn(FigureColor.White, FieldLetter.f, 2);
            string infoPawn6 = pawn6.InfoFigure();
            Console.WriteLine(infoPawn6);


            Pawn pawn8 = new Pawn(FigureColor.White, FieldLetter.h, 2);
            string infoPawn8 = pawn8.InfoFigure();
            Console.WriteLine(infoPawn8);

            // создаем белую пешку на g2
            Pawn pawn7 = new Pawn(FigureColor.White, FieldLetter.g, 2);

            // выводим информацию о пешке на экран
            string infoPawn7 = pawn7.InfoFigure();
            Console.WriteLine("Белая пешка: " + infoPawn7);

            // пешка ходит на g3

            string pawn7AfterMove = pawn7.Move(FieldLetter.g, 3);
            Console.WriteLine("Пешка делает ход: " + pawn7AfterMove);

            // выводим информацию о пешке на экран (где она находится после хода)

            string infoPawn7AfterMove = pawn7.InfoFigure();
            Console.WriteLine("Белая пешка после хода: " + infoPawn7AfterMove);
        }

        private static void PlayGame()
        {
            // Черные фигуры

            Rook blackRook1 = new Rook(FigureColor.Black, FieldLetter.a, 8);
            Console.WriteLine(blackRook1.InfoFigure());


            Rook blackRook2 = new Rook(FigureColor.Black, FieldLetter.h, 8);
            Console.WriteLine(blackRook2.InfoFigure());


            Knight blackKnight1 = new Knight(FigureColor.Black, FieldLetter.b, 8);
            Console.WriteLine(blackKnight1.InfoFigure());

            Knight blackKnight2 = new Knight(FigureColor.Black, FieldLetter.g, 8);
            Console.WriteLine(blackKnight2.InfoFigure());

            Bishop blackBishop1 = new Bishop(FigureColor.Black, FieldLetter.c, 8);
            Console.WriteLine(blackBishop1.InfoFigure());

            Bishop blackBishop2 = new Bishop(FigureColor.Black, FieldLetter.f, 8);
            Console.WriteLine(blackBishop2.InfoFigure());

            King blackKing = new King(FigureColor.Black, FieldLetter.d, 1);
            Console.WriteLine(blackKing.InfoFigure());

            Queen blackQueen = new Queen(FigureColor.Black, FieldLetter.e, 1);
            Console.WriteLine(blackQueen.InfoFigure());


            Pawn blackPawn1 = new Pawn(FigureColor.Black, FieldLetter.a, 7);
            Console.WriteLine(blackPawn1.InfoFigure());

            Pawn blackPawn2 = new Pawn(FigureColor.Black, FieldLetter.b, 7);
            Console.WriteLine(blackPawn2.InfoFigure());

            Pawn blackPawn3 = new Pawn(FigureColor.Black, FieldLetter.c, 7);
            Console.WriteLine(blackPawn3.InfoFigure());

            Pawn blackPawn4 = new Pawn(FigureColor.Black, FieldLetter.d, 7);
            Console.WriteLine(blackPawn4.InfoFigure());

            Pawn blackPawn5 = new Pawn(FigureColor.Black, FieldLetter.e, 7);
            Console.WriteLine(blackPawn5.InfoFigure());

            Pawn blackPawn6 = new Pawn(FigureColor.Black, FieldLetter.f, 7);
            Console.WriteLine(blackPawn6.InfoFigure());

            Pawn blackPawn7 = new Pawn(FigureColor.Black, FieldLetter.g, 7);
            Console.WriteLine(blackPawn7.InfoFigure());


            Pawn blackPawn8 = new Pawn(FigureColor.Black, FieldLetter.h, 7);
            Console.WriteLine(blackPawn8.InfoFigure());


            //Белые фигуры
            Rook whitekRook1 = new Rook(FigureColor.White, FieldLetter.a, 8);
            Console.WriteLine(whitekRook1.InfoFigure());


            Rook whitekRook2 = new Rook(FigureColor.White, FieldLetter.h, 8);
            Console.WriteLine(whitekRook2.InfoFigure());


            Knight whitekKnight1 = new Knight(FigureColor.White, FieldLetter.b, 8);
            Console.WriteLine(whitekKnight1.InfoFigure());

            Knight whitekKnight2 = new Knight(FigureColor.White, FieldLetter.g, 8);
            Console.WriteLine(whitekKnight2.InfoFigure());

            Bishop whitekBishop1 = new Bishop(FigureColor.White, FieldLetter.c, 8);
            Console.WriteLine(whitekBishop1.InfoFigure());

            Bishop whitekBishop2 = new Bishop(FigureColor.White, FieldLetter.f, 8);
            Console.WriteLine(whitekBishop2.InfoFigure());

            King whitekKing = new King(FigureColor.White, FieldLetter.d, 1);
            Console.WriteLine(whitekKing.InfoFigure());

            Queen whitekQueen = new Queen(FigureColor.White, FieldLetter.e, 1);
            Console.WriteLine(whitekQueen.InfoFigure());


            Pawn whitekPawn1 = new Pawn(FigureColor.White, FieldLetter.a, 7);
            Console.WriteLine(whitekPawn1.InfoFigure());

            Pawn whitekPawn2 = new Pawn(FigureColor.White, FieldLetter.b, 7);
            Console.WriteLine(whitekPawn2.InfoFigure());

            Pawn whitekPawn3 = new Pawn(FigureColor.White, FieldLetter.c, 7);
            Console.WriteLine(whitekPawn3.InfoFigure());

            Pawn whitekPawn4 = new Pawn(FigureColor.White, FieldLetter.d, 7);
            Console.WriteLine(whitekPawn4.InfoFigure());

            Pawn whitekPawn5 = new Pawn(FigureColor.White, FieldLetter.e, 7);
            Console.WriteLine(whitekPawn5.InfoFigure());

            Pawn whitekPawn6 = new Pawn(FigureColor.White, FieldLetter.f, 7);
            Console.WriteLine(whitekPawn6.InfoFigure());

            Pawn whitekPawn7 = new Pawn(FigureColor.White, FieldLetter.h, 7);
            Console.WriteLine(whitekPawn7.InfoFigure());

            Pawn whitekPawn8 = new Pawn(FigureColor.White, FieldLetter.h, 7);
            Console.WriteLine(whitekPawn8.InfoFigure());

            List<Figure> list = new List<Figure>();
            list.Add(blackRook1);
            list.Add(blackRook2);
            list.Add(blackKnight1);
            list.Add(blackKnight2);
            list.Add(blackBishop1);
            list.Add(blackBishop2);
            list.Add(blackKing);
            list.Add(blackQueen);
            list.Add(blackPawn1);
            list.Add(blackPawn2);
            list.Add(blackPawn3);
            list.Add(blackPawn4);
            list.Add(blackPawn5);
            list.Add(blackPawn6);
            list.Add(blackPawn7);
            list.Add(blackPawn8);

            list.Add(whitekRook1);
            list.Add(whitekRook2);
            list.Add(whitekKnight1);
            list.Add(whitekKnight2);
            list.Add(whitekBishop1);
            list.Add(whitekBishop2);
            list.Add(whitekKing);
            list.Add(whitekQueen);
            list.Add(whitekPawn1);
            list.Add(whitekPawn2);
            list.Add(whitekPawn3);
            list.Add(whitekPawn4);
            list.Add(whitekPawn5);
            list.Add(whitekPawn6);
            list.Add(whitekPawn7);
            list.Add(whitekPawn8);


            foreach (var item in list)
            {

                Console.WriteLine(item.InfoFigure());
            }


        }
    }

}
