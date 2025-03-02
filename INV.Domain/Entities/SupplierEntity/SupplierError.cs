﻿using INV.Domain.Shared;

namespace INV.Domain.Entities.SupplierEntity
{
    public static class SupplierError
    {
        public static Error RCExsist(string rc) =>
            Error.Conflict("SupplierConflict.RCExsist", $"This {rc} is already used by another supplier");
        public static Error NISExsist { get; } =
            Error.Conflict("SupplierConflict.NISExsist", "This NIS is already used by another supplier");
        public static Error RIBExsist { get; } =
            Error.Conflict("SupplierConflict.RIBExsist", "This RIB is already used by another supplier");

    }
}