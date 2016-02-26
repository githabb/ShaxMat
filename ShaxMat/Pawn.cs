using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShaxMat
{
    public class Pawn : Figure
    {

        public Pawn() : base()
        {
            this.Name = FigureName.Pawn;
        }


        public Pawn(FigureColor color, FieldLetter letter, byte number) :
            base(color, letter, number)
        {
            this.Name = FigureName.Pawn;
        }


        public override bool CanMove(FieldLetter letter, byte number)
        {
            if (Letter != letter)
                return false;

            if (Color == FigureColor.White)
            {
                if (this.Number == 2 && (number == 3 || number == 4))
                    return true;

                if (this.Number >= 3 && this.Number <= 7)
                    if (number == this.Number + 1)
                        return true;

            }
            else if (Color == FigureColor.Black)
            {
                if (this.Number == 7 && (number == 6 || number == 5 ))
                    return true;

                if (this.Number <= 6 && this.Number >=2)
                    if (number == this.Number -1)
                        return true;
            }
            return false;




        }
    }
}