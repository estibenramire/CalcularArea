using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularArea.Formas
{
    internal class Rombo : Poligono
    {
        public Rombo(int diagonalMayor, int diagonalMenor) : base(4, diagonalMayor, diagonalMenor)
        {
        }
        public int CalcularArea()
        {
            return (_base * _altura) / 2;
        }
    }
}
