using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularArea
{
    internal class Poligono : Forma
    {
        public int _numeroLados;
        public int _base;
        public int _altura;

    
        public Poligono(int numeroLados, int basePoligono, int altura) 
        {
            _numeroLados = numeroLados;
            _base = basePoligono;
            _altura = altura;
        }

       
    }
}
