using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShaxMat;

namespace ShaxMatTest
{
    [TestClass]
    public class BishopTest
    {
        #region CanMove tests

        [TestMethod]
        public void CanMove_White_e2()
        {
            Bishop bishop = new Bishop(FigureColor.White, FieldLetter.a, 1);

            Assert.IsTrue(bishop.CanMove(FieldLetter.b, 2));
            Assert.IsTrue(bishop.CanMove(FieldLetter.c, 3));
        }

        [TestMethod]
        public void CanMove_White_e2_CannotMove()
        {
            Bishop bishop = new Bishop(FigureColor.White, FieldLetter.a, 1);

            Assert.IsFalse(bishop.CanMove(FieldLetter.b, 1));
            Assert.IsFalse(bishop.CanMove(FieldLetter.e, 2));

            Assert.IsFalse(bishop.CanMove(FieldLetter.a, 1));
        }


        [TestMethod]
        public void CanMove_White_e2_xodVerticalno()
        {
            Bishop bishop = new Bishop(FigureColor.White, FieldLetter.f, 1);

            Assert.IsFalse(bishop.CanMove(FieldLetter.f, 2));
            Assert.IsFalse(bishop.CanMove(FieldLetter.f, 4));

            Assert.IsFalse(bishop.CanMove(FieldLetter.f, 6));
        }


        [TestMethod]
        public void CanMove_White_e2_xodLeftDiogonal()
        {
            Bishop bishop = new Bishop(FigureColor.White, FieldLetter.d, 3);

            Assert.IsTrue(bishop.CanMove(FieldLetter.e, 4));
            Assert.IsTrue(bishop.CanMove(FieldLetter.f, 5));

            Assert.IsTrue(bishop.CanMove(FieldLetter.g, 6));
        }

        [TestMethod]
        public void CanMove_White_e2_xodPravDiogonal()
        {
            Bishop bishop = new Bishop(FigureColor.White, FieldLetter.f, 1);

            Assert.IsTrue(bishop.CanMove(FieldLetter.g, 2));
            //Assert.IsTrue(bishop.CanMove(FieldLetter.d, 3));

            Assert.IsTrue(bishop.CanMove(FieldLetter.h, 3));
        }

        [TestMethod]
        public void CanMove_Black_e8_xodPravDiogonal()
        {
            Bishop bishop = new Bishop(FigureColor.Black, FieldLetter.e, 8);

            Assert.IsTrue(bishop.CanMove(FieldLetter.d, 7));
            Assert.IsTrue(bishop.CanMove(FieldLetter.c, 6));

            Assert.IsTrue(bishop.CanMove(FieldLetter.b, 5));
        }

        [TestMethod]
        public void CanMove_Black_d8_xodPravoDiogonal()
        {
            Bishop bishop = new Bishop(FigureColor.Black, FieldLetter.d, 8);

            Assert.IsTrue(bishop.CanMove(FieldLetter.c, 7));
            Assert.IsTrue(bishop.CanMove(FieldLetter.b, 6));

            Assert.IsTrue(bishop.CanMove(FieldLetter.a, 5));
        }


        [TestMethod]
        public void CanMove_White_c6_xodBlackLeftDiogonal()
        {
            Bishop bishop = new Bishop(FigureColor.Black, FieldLetter.c, 6);

            Assert.IsTrue(bishop.CanMove(FieldLetter.d, 5));
            Assert.IsTrue(bishop.CanMove(FieldLetter.e, 4));

            Assert.IsTrue(bishop.CanMove(FieldLetter.f, 3));
        }

        [TestMethod]
        public void CanMove_Black_f8_xodVerticalno()
        {
            Bishop bishop = new Bishop(FigureColor.Black, FieldLetter.f, 8);

            Assert.IsFalse(bishop.CanMove(FieldLetter.f, 6));
            Assert.IsFalse(bishop.CanMove(FieldLetter.f, 6));

            Assert.IsFalse(bishop.CanMove(FieldLetter.f, 5));
        }

        [TestMethod]
        public void CanMove_Black_f7_xodBlackGorzontal()
        {
            Bishop bishop = new Bishop(FigureColor.Black, FieldLetter.e, 7);

            Assert.IsFalse(bishop.CanMove(FieldLetter.d, 7));
            Assert.IsFalse(bishop.CanMove(FieldLetter.c, 7));

            Assert.IsFalse(bishop.CanMove(FieldLetter.a, 7));
        }


        [TestMethod]
        public void CanMove_Black_b5_xodBlackKakKon()
        {
            Bishop bishop = new Bishop(FigureColor.Black, FieldLetter.b, 5);

            Assert.IsFalse(bishop.CanMove(FieldLetter.c, 3));
            Assert.IsFalse(bishop.CanMove(FieldLetter.e, 4));

            Assert.IsFalse(bishop.CanMove(FieldLetter.a, 7));
        }

        #endregion
    }
}
