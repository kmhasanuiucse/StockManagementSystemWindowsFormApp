﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem.Model
{
    public class Supplier
    {
        public int Id { set; get; }
        public String Code { set; get; }
        public string Name { set; get; }
        public string Address { set; get; }
        public string Email { set; get; }
        public string Contact { set; get; }
        public string ContactPerson { set; get; }
    }
}