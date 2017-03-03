using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaForum.Models
{
    public class User
    {
        public User()
        {
            this.Topics = new List<Topic>();
        }

        public int Id { get; set; }
        public string Username { get; set; }
        public string Email{ get; set; }
        public string Password { get; set; }
        public bool IsAdmin { get; set; }

        public ICollection<Topic> Topics { get; set; }
    }
}
