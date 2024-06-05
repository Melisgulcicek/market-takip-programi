using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace market_takip_programi.Models
{
    public class Account
    {
        public int AccountId { get; set; }
        public string ItemName { get; set; }
        public int ItemPrice { get; set; }
        public int ItemStock { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }

}
