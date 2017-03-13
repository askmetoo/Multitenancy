﻿using System;
using System.Collections.Generic;
using MultiTenancyExperiment.Dal.Base;
using MultiTenancyExperiment.Dal.Multitenancy;

namespace MultiTenancyExperiment.Dal.Entities
{
    [Tenant("Tenant")]
    public class Note : IBaseEntity
    {
        public Guid Id { get; set; }

        public string Tenant { get; private set; }

        public string Message { get; set; }

        public DateTime Timestamp { get; set; }

        public string Author { get; set; }

        public virtual ICollection<Adendum> Adendums { get; set; } 
    }
}
