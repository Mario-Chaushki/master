using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PizzaForum.Data;

namespace PizzaForum.Services
{
    public abstract class Service
    {
        protected Service()
        {
            this.Context = Data.Data.Context;
        }
        protected PizzaForumContext Context { get; }
    }
}
