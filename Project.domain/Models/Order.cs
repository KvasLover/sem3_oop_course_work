﻿using Project.domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Food_delivery.Models
{
    public class Order : DomainObject
    {
        //public string Full_name { get; set; }
        public Customer customer { get; set; }
        public Product product { get; set; }
        public string price { get; set; }
        public string date { get; set; }
        public string time { get; set; }
        public Delivery delivery { get; set; }
        public string target_address { get; set; }
    }
}
