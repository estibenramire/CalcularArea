using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularArea.Formas
{
    internal class Rectangulo : Poligono
    {
        public Rectangulo(int baseRectangulo, int altura):base(4, baseRectangulo, altura)
        {
        }

        public int CalcularArea()
        {
            return _base * _altura;
        }
    }
}
