using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularArea.Formas
{
    internal class Triangulo : Poligono
    {
        private int _lado1;
        private int _lado2;
        private int _lado3;

        public int Lado1 { get => _lado1; set => _lado1 = value; }
        public int Lado2 { get => _lado2; set => _lado2 = value; }
        public int Lado3 { get => _lado3; set => _lado3 = value; }
        public Triangulo(int lado1,int lado2,int lado3) : base(3)
        {
            Lado1 = lado1;
            Lado2 = lado2;
            Lado3 = lado3;

        }

     

        public override double GetArea()
        {
           // formula de henon
              double s = (Lado1 + Lado2 + Lado3) / 2.0;
              return Math.Sqrt(s * (s - Lado1) * (s - Lado2) * (s - Lado3));

        }

        public override double GetPerimeter()
        {
            return Lado1 + Lado2 + Lado3;
        }
    }
}
