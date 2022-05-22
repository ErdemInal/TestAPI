using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class OrderDetail
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public decimal UnitPrice { get; set; }
        public short Quantity { get; set; }
        public float Discount { get; set; }

        //public Order Orders { get; set; }
        //public Product Products { get; set; }
    }
}
