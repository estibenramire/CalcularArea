using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularArea
{
    public abstract class Poligono : Forma2D
    {
        public int _numeroLados;
        //public int _base;
        //public int _altura;
        //, int basePoligono, int altura



        public Poligono(int numeroLados) 
        {
            _numeroLados = numeroLados;
            //_base = basePoligono;
            //_altura = altura;
        }

    
    }
}
