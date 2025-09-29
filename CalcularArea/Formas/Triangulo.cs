using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularArea.Formas
{
    internal class Triangulo: Poligono
    {

        public Triangulo(int baseTriangulo, int altura) : base(3, baseTriangulo, altura)
        {
        }
        public int CalcularArea()
        {
            return (_base * _altura) / 2;
        }
    }
}
