using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularArea.Formas
{
    internal class Elipse: Forma
    {
        public double _radioMayor;
        public double _radioMenor;
   
        public Elipse(double radioMayor, double radioMenor)
        {
            _radioMayor = radioMayor;
            _radioMenor = radioMenor;
        }
        public double CalcularArea()
        {
            return Math.PI * _radioMayor * _radioMenor;
        }
    }
}
