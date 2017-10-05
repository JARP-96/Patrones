using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core2
{
    internal class HistogramTranformer : IDataTransformer
    {
        public override List<double> TransformData(List<double> data)
        {
            double mi = data.Min();
            double ma = data.Max();
            int parts = 10;
            double size = (ma - mi) / parts;
            List<double> histogram = new List<double>(parts);
            foreach (double element in data)
            {
                int part = (int)((element-mi) / size);
                histogram[parts]++;
            }
            return histogram;
        }
    }
}
