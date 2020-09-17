using System;
using System.Collections.Generic;
using System.Linq;
using System.Tasks;

namespace PriceQuotationApp.Models
{
    public class PriceQuotation
    {
        public decimal subtotal { get; set; }
        public decimal discountPercent { get; set; }
        public decimal discountAmount { get; set; }
        public decimal calculateTotal()
        {
            decimal discountAmount = subtotal * discountPercent;
            decimal total = subtotal - discountAmount;
            return total; 
        }
        

    }
}
