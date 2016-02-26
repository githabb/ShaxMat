using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShaxMat
{
    // Конь по-английски будет knight (рыцарь)
    public  class Knight : Figure
    {

        public Knight() : base()
        {
            this.Name = FigureName.Knight;
        }


        public Knight(FigureColor color, FieldLetter letter, byte number) :
                base(color, letter, number)
        {
            this.Name = FigureName.Knight;
        }
    }
}