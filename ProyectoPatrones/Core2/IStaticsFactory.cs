using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core2
{
    public abstract class IStaticsFactory
    {
        public abstract IDataTransformer GetDataTransformer();
        //public abstract IMeanCalculator GetMeanCalculator();
    }
}
