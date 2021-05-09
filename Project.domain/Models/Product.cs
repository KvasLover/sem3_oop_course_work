using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Food_delivery.Models
{
    public class Product
    {
        public string dish { get; set; }
        public string price { get; set; }
        public string avg_score { get; set; }
        public int amount_avail { get; set; }
        public Delivery delivery { get; set; }
    }
}
