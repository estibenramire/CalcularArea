using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularArea.Formas
{
    internal class Rectangulo : Poligono
    {
        private int _base;
        private int _altura;

        public int Base { get => _base; set => _base = value; }
        public int Altura { get => _altura; set => _altura = value; }

        public Rectangulo(int baseRectangulo, int altura):base(4)
        {
        }

        public override double GetArea()
        {
            return Base * Altura;
        }

        public override double GetPerimeter()
        {
            return 2 * (Base + Altura);
        }
    }
}
