using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    internal class AverageCalculator : IMeanCalculator
    {
        public double CalculateMean(List<double> data)
        {

            double noElements = data.Count;
            double sum = data.Sum();
            double resultado = sum / noElements;

            return resultado;
        }
    }
}
