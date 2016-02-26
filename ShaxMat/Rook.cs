using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShaxMat
{
    public class Rook : Figure
    {

        public Rook() : base()
        {
            this.Name = FigureName.Rook;
        }


        public Rook(FigureColor color, FieldLetter letter, byte number) :
                base(color, letter, number)
        {
            this.Name = FigureName.Rook;
        }
        public override bool CanMove(FieldLetter letter, byte number)
        {
            if (!ValidateNumber(number))
                throw new ArgumentOutOfRangeException(nameof(number), number, "Горизонталь может принимать значения от 1 до 8");

            if (!ValidateLetter(letter))
                throw new ArgumentOutOfRangeException(nameof(letter), letter, "Вертикаль может принимать значения от a до h");

            if (Letter == letter && Number != number)
                return true;

            if (Letter != letter && Number == number)
                return true;

            return false;
        }
    }
}
