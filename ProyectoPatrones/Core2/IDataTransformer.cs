﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core2
{
    public abstract class IDataTransformer
    {
        public abstract List<double> TransformData(List<double> data);
    }
}
