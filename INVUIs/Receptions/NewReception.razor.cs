using INV.App.Purchases;
using INV.App.Receipts;
using INV.Domain.Entities.Purchases;
using INV.Domain.Entities.Receptions;
using Microsoft.AspNetCore.Components;

namespace INVUIs.Receptions
{
    public partial class NewReception
    {
        [Inject]
        public IPurchaseOrderService PurchaseOrderService { get; set; }

        [Inject]
        public IReceiptService ReceptionService { get; set; }

        [Parameter]
        public List<PurchaseOrderInfo> purchaseOrderInfos { get; set; } = new();
        [Parameter]
        public PurchaseOrder detailspurchase { get; set; }
        [Parameter]
        public List<TabReception> tabreceptions { get; set; }
        private Guid selectedPurchaseOrderId { get; set; }
     
        private int newreceived;
        protected override async Task OnInitializedAsync()
        {
            purchaseOrderInfos = await PurchaseOrderService.GetPurchaseOrderInfo();
        }

        private async Task OnPurchaseOrderChanged(ChangeEventArgs e)
        {
            if (Guid.TryParse(e.Value.ToString(), out Guid parsedGuid))
            {
                selectedPurchaseOrderId = parsedGuid;
                detailspurchase = await PurchaseOrderService.GetPurchaseOrdersByID(selectedPurchaseOrderId);
                //tabreceptions = await ReceptionService.GetPurchaseOrdersByID(selectedPurchaseOrderId);
            }
        }

        private async Task save(Guid purchse, Guid product, int value)
        {
            //await ReceptionService.UpdateReceivedQuantity(purchse, product, value);
            //tabreceptions = await ReceptionService.GetPurchaseOrdersByID(selectedPurchaseOrderId);
            StateHasChanged();

        }
    }
}

