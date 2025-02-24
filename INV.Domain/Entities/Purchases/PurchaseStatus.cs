using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INV.Domain.Entities.Purchases
{
    public enum PurchaseStatus
    {
        Validated = 1,
        Cancelled = 2,
        Deleted = 3,
        Editing = 4
    }
}
