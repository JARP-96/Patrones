using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    internal class StandardDeviationCalculator : IMeanCalculator
    {
        public double CalculateMean(List<double> values)
        {
            double ret = 0;
            if (values.Count() > 0)
            {  
                double avg = values.Average();
                double sum = values.Sum(d => Math.Pow(d - avg, 2)); 
                ret = Math.Sqrt((sum) / (values.Count() - 1));
            }
            return ret;
        }
    }
}
