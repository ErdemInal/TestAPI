using Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Order : IEntity
    {
        //public Order()
        //{
        //    OrderDetails = new HashSet<OrderDetail>();
        //}
        public int Id { get; set; }

        public int OrderId { get; set; }
        //public string CustomerId { get; set; }
        
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public short Quantity { get; set; }
        public float Discount { get; set; }
        public decimal ExtendedPrice { get; set; }

        public string ContactName { get; set; }

        //public int? EmployeeId { get; set; }
        //public DateTime? OrderDate { get; set; }
        //public DateTime? RequiredDate { get; set; }
        //public DateTime? ShippedDate { get; set; }
        //public int? ShipVia { get; set; }
        //public decimal? Freight { get; set; }
        //public string ShipName { get; set; }

        public string ShipAddress { get; set; }
        //public string ShipCity { get; set; }
        //public string ShipRegion { get; set; }
        //public string ShipPostalCode { get; set; }
        //public string ShipCountry { get; set; }

        //public Customer Customer { get; set; }
        //public Employees Employee { get; set; }
        //public Shippers ShipViaNavigation { get; set; }
        //public ICollection<OrderDetail> OrderDetails { get; set; }


    }
}
