using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Food_delivery.Models
{
    public class Order
    {
        public int id { get; set; }
        public string Full_name { get; set; }
        public Customer customer { get; set; }

    }
}
