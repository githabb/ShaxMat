using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShaxMat
{
    public class Bishop : Figure
    {

        public Bishop() : base()
        {
            this.Name = FigureName.Bishop;
        }


        public Bishop(FigureColor color, FieldLetter letter, byte number) :
            base(color, letter, number)
        {
            this.Name = FigureName.Bishop;
        }
        public override bool CanMove(FieldLetter letter, byte number)
        {
            if (Math.Abs(Letter - letter) == Math.Abs(Number - number))
            {
                if (Letter != letter && Number != number)
                    return true;
            }

            return false;
        }
    }

}