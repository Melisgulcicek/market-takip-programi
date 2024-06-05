using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace market_takip_programi.Models
{
    public class Sale
    {
        public int SaleId { get; set; }
        
        public int ProductPrice { get; set; }
        public int Quantity { get; set; }
        public int TotalPrice { get; set; }
        public DateTime SaleDate { get; set; }

        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public Product Product { get; set; }
    }

}
