using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    internal class PolynomicDataGenerator : IDataGenerator
    {
        public List<double> GenerateData()
        {
            var rtnList = new List<double>();

            for (int i = 0; i < 50; i++)
            {
                rtnList.Add(i*i+i+4);
            }
            return rtnList;
        }
    }
}
