using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShaxMat
{
    public class King : Figure
    {

        public King() : base()
        {
            this.Name = FigureName.King;
        }


        public King(FigureColor color, FieldLetter letter, byte number) :
            base(color, letter, number)
        {
            this.Name = FigureName.King;
        }

        public override bool CanMove(FieldLetter letter, byte number)
        {
            if (!ValidateNumber(number))
                throw new ArgumentOutOfRangeException(nameof(number), number, "Горизонталь может принимать значения от 1 до 8");

            if (Letter != letter && Number == number && (Letter >= letter - 1 && Letter <= letter + 1))
                return true;


            if (this.Number >= 1 && this.Number <= 7 && (Letter >= letter - 1 && Letter <= letter + 1))
                if (number == this.Number + 1)
                    return true;


            if (this.Number <= 8 && this.Number >= 2 && (Letter <= letter + 1 && Letter >= letter - 1))
                if (number == this.Number - 1)
                   return true;


            return false;
        }
        
    }

}
