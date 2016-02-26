using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShaxMat
{
    public abstract class Figure
    {
        public FigureColor Color
        { get; set; }
        public FigureName Name
        { get; set; }
        public FieldLetter Letter
        { get; set; }
        public byte Number
        { get; set; }


        public Figure()
        {
        }


        public Figure(FigureColor color, FieldLetter letter, byte number)
        {
            this.Color =  color;
            this.Letter = letter;
            this.Number = number;
        }
        public string InfoFigure()
        {
           string resalt = string.Format("{0} {1} {2}{3}", Color, Name, Letter, Number);

            return resalt;
        }
        public string Move(FieldLetter letter, byte number)
        {
            if (!ValidateNumber(number))
                throw new ArgumentOutOfRangeException(nameof(number), number, "Горизонталь может принимать значения от 1 до 8");

            this.Letter = letter;
            this.Number = number;

            string resalt = string.Format("{0} {1} {2}{3}", Color, Name, Letter, Number);

            return resalt;
        }


        public virtual bool CanMove(FieldLetter letter, byte number)
        {
            return true;
        }

        public static bool ValidateNumber(byte number)
        {
            if (number >= 1 && number <= 8)
                return true;
            else
                return false;
        }

        public static bool ValidateLetter(FieldLetter letter)
        {
            if ((int)letter >= 1 && (int)letter <= 8)
                return true;
            else
                return false;
        }


    }
}    
