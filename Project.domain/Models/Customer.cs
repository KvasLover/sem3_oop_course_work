﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Food_delivery.Models
{
    public class Customer
    {
        public string Full_name { get; set; }
        public int id { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string phone_number { get; set; }
        public int amount_of_orders { get; set; }
        //public ICollection<Order> Orders { get; set; }
    }
}
