using Project.domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Food_delivery.Models
{
    public class Delivery : DomainObject
    {
        public string Name { get; set; }
        public int avg_deliv_time { get; set; }
        public string time_of_work { get; set; }
        public string main_restaurant { get; set; }
        public string phone_number { get; set; }
        public string avg_deliv_cost { get; set; }
    }
}
