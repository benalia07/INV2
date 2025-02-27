using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INV.Domain.Entities.Receptions
{
    public class TabReception
    {
        public Guid PurchaseId { get; set; }
        public Guid ProductId { get; set; }
        public string Designation { get; set; }
        public string UnitMeasure { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; } 
        public int Received { get; set; }

    }
}
