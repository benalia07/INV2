using INV.App.Suppliers;
using INV.Domain.Entities.SupplierEntity;
using INV.Domain.Shared;
using INVUIs.Suppliers.Models;
using Microsoft.AspNetCore.Components;

namespace INVUIs.Suppliers
{
    public partial class SupplierForm : ComponentBase
    {
        [Parameter]
        public EventCallback<SupplierInfo> OnSave { get; set; }
        [Inject] public ISupplierService SupplierService { get; set; }
        SupplierModel newSupplier = new SupplierModel();
        private bool displayModal = false;
        Result result;
        private String success = String.Empty;

        private void close()
        {
            newSupplier = new SupplierModel();
            displayModal = false;
            StateHasChanged(); 
        }


        public void ShowModal()
        {
            displayModal = true;
            StateHasChanged();
        }

        private async Task OnCreate()
        {
            try
            {
                var sup = new Supplier()
                {
                    Id = Guid.NewGuid(),
                    ManagerName = newSupplier.NameSupplier,
                    CompanyName = newSupplier.NameCompany,
                    Email = newSupplier.Email,
                    Address = newSupplier.Address,
                    Phone = newSupplier.Phone,
                    ART = newSupplier.ART,
                    NIF = newSupplier.NIF,
                    RC = newSupplier.RC,
                    NIS = newSupplier.NIS,
                    RIB = newSupplier.RIB,
                    BankAgency = newSupplier.BankAgency
                };

                result = await SupplierService.AddSupplier(sup);

               // await OnSave.InvokeAsync(sup);
                success = "the supplier has been added successfully";
                if (result.Successed)
                {
                    await ClearForm();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
private async Task ClearForm()
        {
            newSupplier = new SupplierModel();
        }
    }
}