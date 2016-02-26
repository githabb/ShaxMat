using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShaxMat;

namespace ShaxMatTest
{
    [TestClass]
    public class PawnTest
    {
        #region CanMove tests

        [TestMethod]
        public void CanMove_White_e2()
        {
            Pawn pawn = new Pawn(FigureColor.White, FieldLetter.e, 2);

            Assert.IsTrue(pawn.CanMove(FieldLetter.e, 3));
            Assert.IsTrue(pawn.CanMove(FieldLetter.e, 4));
        }

        [TestMethod]
        public void CanMove_White_e2_CannotMove()
        {
            Pawn pawn = new Pawn(FigureColor.White, FieldLetter.e, 2);

            Assert.IsFalse(pawn.CanMove(FieldLetter.e, 5));
            Assert.IsFalse(pawn.CanMove(FieldLetter.e, 2));

            Assert.IsFalse(pawn.CanMove(FieldLetter.a, 3));
        }

        [TestMethod]
        public void CanMove_White_g3_xodPriymo()
        {
            Pawn pawn = new Pawn(FigureColor.White, FieldLetter.g, 3);

            Assert.IsTrue(pawn.CanMove(FieldLetter.g, 4));
            Assert.IsFalse(pawn.CanMove(FieldLetter.h, 4));

            Assert.IsFalse(pawn.CanMove(FieldLetter.g, 6));
        }

        [TestMethod]
        public void CanMove_White_c3_xodKakKonem()
        {
            Pawn pawn = new Pawn(FigureColor.White, FieldLetter.c, 3);

            Assert.IsFalse(pawn.CanMove(FieldLetter.d, 5));
            Assert.IsFalse(pawn.CanMove(FieldLetter.a, 4));

            Assert.IsTrue(pawn.CanMove(FieldLetter.c, 4));
        }

        [TestMethod]
        public void CanMove_Black_c7_xodVertikal()
        {
            Pawn pawn = new Pawn(FigureColor.Black, FieldLetter.c, 7);

            Assert.IsTrue(pawn.CanMove(FieldLetter.c, 6));
            Assert.IsTrue(pawn.CanMove(FieldLetter.c, 5));

            Assert.IsFalse(pawn.CanMove(FieldLetter.c, 4));
        }

        [TestMethod]
        public void CanMove_Black_f6_xodVertikal()
        {
            Pawn pawn = new Pawn(FigureColor.Black, FieldLetter.f, 6);

            Assert.IsTrue(pawn.CanMove(FieldLetter.f, 5));
            Assert.IsFalse(pawn.CanMove(FieldLetter.f, 4));

            Assert.IsFalse(pawn.CanMove(FieldLetter.c, 4));
        }
        #endregion
    }
}
