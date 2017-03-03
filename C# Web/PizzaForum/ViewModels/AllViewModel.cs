using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaForum.ViewModels
{
    public class AllViewModel
    {
        public LoggedInUserViewModel User { get; set; }

        public IEnumerable<AllCategoryViewModel> Categories { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (AllCategoryViewModel acvm in Categories)
            {
                sb.Append(acvm);
            }
            return sb.ToString();
        }
    }
}
