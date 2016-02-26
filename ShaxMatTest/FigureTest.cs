using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShaxMat;

namespace ShaxMatTest
{
    [TestClass]
    public class FigureTest
    {
        [TestMethod]
        public void ValidateNumber()
        {
            Assert.IsTrue(Figure.ValidateNumber(1));
            Assert.IsTrue(Figure.ValidateNumber(8));
            Assert.IsTrue(Figure.ValidateNumber(5));

            Assert.IsFalse(Figure.ValidateNumber(0));
            Assert.IsFalse(Figure.ValidateNumber(9));
        }

        [TestMethod]
        public void ValidateLetter()
        {
            Assert.IsTrue(Figure.ValidateLetter(FieldLetter.a));
            Assert.IsTrue(Figure.ValidateLetter(FieldLetter.h));
            Assert.IsTrue(Figure.ValidateLetter(FieldLetter.e));

            Assert.IsFalse(Figure.ValidateLetter((FieldLetter)0));
            Assert.IsFalse(Figure.ValidateLetter((FieldLetter)9));
        }
    }
}
