﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disruptor3_Net.Interfaces
{
    public interface IEventReleaseAware
    {
        void setEventReleaser(IEventReleaser eventReleaser);
    }
}
