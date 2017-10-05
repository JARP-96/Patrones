using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core2
{
    internal class DataContainer : IClonableDataContainer
    {
        public List<double> Data { get; set; }
        public override IClonableDataContainer Clone()
        {
            DataContainer clonedData = new DataContainer();
            clonedData.Data = new List<double>(Data);
            return clonedData;
        }
    }
}
