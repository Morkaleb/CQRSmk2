﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRSWITHES.Infra.ReadModels
{
    public abstract class ReadModel
    {
        public abstract void EventPublish(EventModel anEvent);
    }
}
