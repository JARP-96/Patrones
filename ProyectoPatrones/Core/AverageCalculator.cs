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
            var rtnList = new List<double>();

            var noElements = rtnList.Count;
            var sum = rtnList.Sum(x => Convert.ToInt32(x)));


            return rtnList;
        }
    }
}
