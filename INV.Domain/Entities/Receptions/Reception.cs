using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INV.Domain.Entities.Receptions
{
    public class Reception
    {
        public Guid Id { get; set; }

        public Guid PurchaseOrderId { get; set; }

        public DateOnly Date { get; set; }

        public DateOnly DeliveryDate { get; set; }

        public string DeliveryNumber { get; set; }

        public ReceptionStatus Status { get; set; }
    }
}
