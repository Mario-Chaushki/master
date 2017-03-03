using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaForum.Models
{
    public class Category
    {
        public Category()
        {
            this.Topics = new List<Topic>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Topic> Topics { get; set; }
    }
}
