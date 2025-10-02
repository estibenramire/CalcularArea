using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularArea.Formas
{
    internal class Elipse : Forma2D
    {
        private double _radioMayor;
        private double _radioMenor;

        public double RadioMayor { get => _radioMayor; set => _radioMayor = value; }
        public double RadioMenor { get => _radioMenor; set => _radioMenor = value; }
        public Elipse(double radioMayor, double radioMenor)
        {
            RadioMayor = radioMayor;
            RadioMenor = radioMenor;
        }

       

        public override double GetArea()
        {
            return Math.PI * RadioMayor * RadioMenor;
        }

        public override double GetPerimeter()
        {
            return Math.PI*(RadioMayor + RadioMenor);
        }
    }
}
