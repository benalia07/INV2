﻿using INV.App.Suppliers;
using INVUIs.Suppliers;
using Microsoft.AspNetCore.Components;

namespace INV.Web.Components.Pages.Suppliers
{
    public partial class SupplierListPage : ComponentBase
    {
        [Inject] public ISupplierService supplierService { get; set; }

        

        private List<SupplierInfo> suppliers;

        string texte = DateTime.Now.ToString("dd/MM/yyyy HH:ss");

        protected override async Task OnInitializedAsync()
        {
            suppliers = await supplierService.GetAllSupplier();
        }
       
    }
}