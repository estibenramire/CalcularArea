using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularArea.Formas
{
    internal class Rombo : Poligono
    {
        private int _diagonalMayor;
        private int _diagonalMenor;

        public int DiagonalMayor { get => _diagonalMayor; set => _diagonalMayor = value; }
        public int DiagonalMenor { get => _diagonalMenor; set => _diagonalMenor = value; }
        public Rombo(int diagonalMayor, int diagonalMenor) : base(4)
        {
            DiagonalMayor = diagonalMayor;
            DiagonalMenor = diagonalMenor;
        }


        public override double GetArea()
        {
            return (DiagonalMayor * DiagonalMenor) / 2;
        }

        public override double GetPerimeter()
        {
            return (DiagonalMayor * DiagonalMenor) / 2;
        }
    }
}
