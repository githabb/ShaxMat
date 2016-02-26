using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShaxMat;

namespace ShaxMatTest
{
    [TestClass]
    public class QueenTest
    {
        #region CanMove tests

        [TestMethod]
        public void CanMove_White_d5_()
        {
            Queen queen = new Queen(FigureColor.White, FieldLetter.d, 5);

            Assert.IsTrue(queen.CanMove(FieldLetter.d, 1));
            Assert.IsTrue(queen.CanMove(FieldLetter.e, 4));
        }


        [TestMethod]
        public void CanMove_White_d5_storonuChernix()
        {
            Queen queen = new Queen(FigureColor.White, FieldLetter.d, 5);

            Assert.IsTrue(queen.CanMove(FieldLetter.d, 7));
            Assert.IsTrue(queen.CanMove(FieldLetter.f, 7));
            Assert.IsTrue(queen.CanMove(FieldLetter.g, 5));
        }


        [TestMethod]
        public void CanMove_Black_c7_storonuWhite()
        {
            Queen queen = new Queen(FigureColor.Black, FieldLetter.c, 7);

            Assert.IsTrue(queen.CanMove(FieldLetter.g, 3));
            Assert.IsTrue(queen.CanMove(FieldLetter.a, 5));
            Assert.IsTrue(queen.CanMove(FieldLetter.c, 5));

        }

        [TestMethod]
        public void CanMove_Black_c7_storonu()
        {
            Queen queen = new Queen(FigureColor.Black, FieldLetter.c, 7);

            Assert.IsFalse(queen.CanMove(FieldLetter.g, 8));
            Assert.IsFalse(queen.CanMove(FieldLetter.h, 5));
            Assert.IsTrue(queen.CanMove(FieldLetter.c, 1));

        }
        [TestMethod]
        public void CanMove_Black_c7_storonuXodit()
        {
            Queen queen = new Queen(FigureColor.Black, FieldLetter.c, 7);

            Assert.IsFalse(queen.CanMove(FieldLetter.g, 6));
            Assert.IsFalse(queen.CanMove(FieldLetter.h, 3));
            Assert.IsTrue(queen.CanMove(FieldLetter.a, 5));
            Assert.IsFalse(queen.CanMove(FieldLetter.e, 3));
        }
        #endregion
    }
}
