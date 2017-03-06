using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoftUniStore.Data;

namespace SoftUniStore.Services
{
    public abstract class Service
    {
        public Service()
        {
            this.Context = Data.Data.Context;
            Context.Database.CreateIfNotExists();
        }
        public SoftUniStoreContext Context { get; }
    }
}
