using INV.Domain.Entities.SupplierEntity;
using Microsoft.AspNetCore.Components;

namespace INVUIs.Suppliers
{
    public partial class SupplierDetail
    {
        [Parameter] public Supplier Supplier { get; set; }
        private bool display = false;
        private SupplierForm supplierForm;

        public void visibility()
        {
            display = !display;
            StateHasChanged();
        }

        
    }
}