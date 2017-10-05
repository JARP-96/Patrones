using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core2
{
    public class RootTransformer : IDataTransformer
    {
        public override List<double> TransformData(List<double> data)
        {
            List<double> transformedData = new List<double>();
            foreach(double element in transformedData)
            {
                transformedData.Add(Math.Sqrt(element));
            }
            return transformedData;
        }
    }
}
