using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShaxMat;

namespace ShaxMatTest
{
    [TestClass]
    public class KingTest
    {
        #region CanMove tests

        [TestMethod]
        public void CanMove_White_b3_xodPraveln()
        {
            King king = new King(FigureColor.White, FieldLetter.e, 4);


            Assert.IsTrue(king.CanMove(FieldLetter.e, 5));
            Assert.IsTrue(king.CanMove(FieldLetter.d, 5));
            Assert.IsTrue(king.CanMove(FieldLetter.f, 5));

            Assert.IsTrue(king.CanMove(FieldLetter.e, 3));
            Assert.IsTrue(king.CanMove(FieldLetter.d, 3));
            Assert.IsTrue(king.CanMove(FieldLetter.f, 3));
            Assert.IsTrue(king.CanMove(FieldLetter.d, 4));

            Assert.IsTrue(king.CanMove(FieldLetter.f, 4));

        }

        [TestMethod]
        public void CanMove_White_b3_xodNeprav()
        {
            King king = new King(FigureColor.White, FieldLetter.e, 4);


            Assert.IsFalse(king.CanMove(FieldLetter.b, 3));
            Assert.IsFalse(king.CanMove(FieldLetter.c, 5));
            Assert.IsFalse(king.CanMove(FieldLetter.a, 5));

            Assert.IsFalse(king.CanMove(FieldLetter.e, 6));
            Assert.IsFalse(king.CanMove(FieldLetter.g, 2));
            Assert.IsFalse(king.CanMove(FieldLetter.f, 7));
            Assert.IsFalse(king.CanMove(FieldLetter.e, 7));
            Assert.IsFalse(king.CanMove(FieldLetter.d, 8));
            Assert.IsFalse(king.CanMove(FieldLetter.f, 7));
            Assert.IsFalse(king.CanMove(FieldLetter.e, 2));
            Assert.IsFalse(king.CanMove(FieldLetter.f, 1));
            Assert.IsFalse(king.CanMove(FieldLetter.a, 2));
            Assert.IsFalse(king.CanMove(FieldLetter.c, 6));
            Assert.IsFalse(king.CanMove(FieldLetter.b, 7));
            Assert.IsFalse(king.CanMove(FieldLetter.c, 8));
            Assert.IsFalse(king.CanMove(FieldLetter.a, 8));
            Assert.IsFalse(king.CanMove(FieldLetter.a, 1));
            Assert.IsFalse(king.CanMove(FieldLetter.b, 1));
            Assert.IsFalse(king.CanMove(FieldLetter.g, 6));
            Assert.IsFalse(king.CanMove(FieldLetter.f, 7));
            Assert.IsFalse(king.CanMove(FieldLetter.h, 6));
            Assert.IsFalse(king.CanMove(FieldLetter.f, 7));
            Assert.IsFalse(king.CanMove(FieldLetter.h, 8));
            Assert.IsFalse(king.CanMove(FieldLetter.h, 4));
            Assert.IsFalse(king.CanMove(FieldLetter.c, 8));

            Assert.IsFalse(king.CanMove(FieldLetter.d, 7));
            Assert.IsFalse(king.CanMove(FieldLetter.e, 1));
            Assert.IsFalse(king.CanMove(FieldLetter.e, 4));

        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void CanMove_InvalidField()
        {
            King king = new King(FigureColor.White, FieldLetter.e, 4);

            king.CanMove(FieldLetter.e, 9);
        }

        #endregion
    }
}
