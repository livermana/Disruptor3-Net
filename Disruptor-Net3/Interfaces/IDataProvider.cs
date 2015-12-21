﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disruptor_Net3.Interfaces
{
    public interface IDataProvider<T>
    {
        T get(long sequence);
    }
}
