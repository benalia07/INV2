using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INV.App.PurchaseOrders
{
    public class PurchaseProductInfo
    {
        public Guid ProductId {      get; set; }
        public string ProductName { get; set; }
        public string ProductMU { get; set; }
        public int TVA { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
