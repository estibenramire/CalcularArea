using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularArea.Formas
{
    internal class Circulo :Elipse
    {
        //public double Radio { get { return this._radioMayor; } }
        public double Radio { get { return this.RadioMayor; } }
      
        public Circulo(double radio) : base(radio, radio)
        {
        }

    }
}
