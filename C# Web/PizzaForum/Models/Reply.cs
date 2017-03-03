using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaForum.Models
{
    public class Reply
    {
        public int Id { get; set; }
        public string Context { get; set; }
        public DateTime PublishDate { get; set; }
        public string ImageUrl { get; set; }
    }
}
