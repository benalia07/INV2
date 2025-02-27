using INV.App.Purchases;
using INV.Domain.Entities.Purchases;
using INVUIs.Receptions;
using Microsoft.AspNetCore.Components;

namespace INV.Web.Components.Pages.Receptions
{
    public partial class NewReceptionPage
    {
        [Inject] public IPurchaseOrderService PurchaseOrderService { get; set; }
        public List<PurchaseOrderInfo> listpurchasesinfo;
        public PurchaseOrder order;
        public NewReception newReception;
        protected override async Task OnInitializedAsync()
        {
            listpurchasesinfo = await PurchaseOrderService.GetPurchaseOrderInfo();


        }





    }
}