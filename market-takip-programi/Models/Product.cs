﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace market_takip_programi.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int StockQuantity { get; set; }
    }

}
