using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularArea
{
    internal class Diagrama
    {
        private List<Forma2D> formas = new List<Forma2D>();
        public void AddForma(Forma2D forma)
        {
            formas.Add(forma);
        }

        public double GetTotalArea()
        {
            double totalArea = 0;
            foreach (var forma in formas)
            {
                totalArea += forma.GetArea();
            }
            return totalArea;
        }


        public double GetTotalPerimeter()
        {
            double totalPerimeter = 0;
            foreach (var forma in formas)
            {
                totalPerimeter += forma.GetPerimeter();
            }
            return totalPerimeter;
        }
    }
}
