using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShaxMat;

namespace ShaxMatTest
{
    [TestClass]
    public class RookTest
    {
        #region CanMove tests

        [TestMethod]
        public void CanMove_White_a1_()
        {

            Rook rook = new Rook(FigureColor.White, FieldLetter.a, 1);

            Assert.IsTrue(rook.CanMove(FieldLetter.b, 1));
            Assert.IsFalse(rook.CanMove(FieldLetter.c, 3));
            Assert.IsFalse(rook.CanMove(FieldLetter.c, 2));
        }


        [TestMethod]
        public void CanMove_White_b4_Gorizont()
        {

            Rook rook = new Rook(FigureColor.White, FieldLetter.b, 4);

            Assert.IsTrue(rook.CanMove(FieldLetter.d, 4));
            Assert.IsTrue(rook.CanMove(FieldLetter.c, 4));
            Assert.IsTrue(rook.CanMove(FieldLetter.h, 4));
        }


        [TestMethod]
        public void CanMove_White_e4_Vertikal()
        {

            Rook rook = new Rook(FigureColor.White, FieldLetter.e, 7);

            Assert.IsTrue(rook.CanMove(FieldLetter.e, 3));
            Assert.IsTrue(rook.CanMove(FieldLetter.e, 8));
            Assert.IsTrue(rook.CanMove(FieldLetter.e, 1));
        }


        [TestMethod]
        public void CanMove_White_e4_xodKakKon()
        {

            Rook rook = new Rook(FigureColor.White, FieldLetter.e, 4);

            Assert.IsFalse(rook.CanMove(FieldLetter.f, 6));
            Assert.IsFalse(rook.CanMove(FieldLetter.d, 6));
            Assert.IsFalse(rook.CanMove(FieldLetter.d, 2));
        }
        [TestMethod]
        public void CanMove_Black_e8_xodKakKon()
        {

            Rook rook = new Rook(FigureColor.White, FieldLetter.e, 8);

            Assert.IsTrue(rook.CanMove(FieldLetter.e, 6));
            Assert.IsTrue(rook.CanMove(FieldLetter.e, 5));
            Assert.IsFalse(rook.CanMove(FieldLetter.d, 2));
        }


        [TestMethod]
        public void CanMove_Black_e8_xodDiogonal()
        {

            Rook rook = new Rook(FigureColor.White, FieldLetter.e, 8);

            Assert.IsFalse(rook.CanMove(FieldLetter.d, 7));
            Assert.IsFalse(rook.CanMove(FieldLetter.c, 6));
            Assert.IsFalse(rook.CanMove(FieldLetter.a, 5));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void CanMove_InvalidField()
        {
            Rook rook = new Rook(FigureColor.White, FieldLetter.a, 1);

            rook.CanMove(0, 1);            
        }


        #endregion

    }
}