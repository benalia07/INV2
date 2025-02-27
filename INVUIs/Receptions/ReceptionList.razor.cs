using INV.App.Purchases;
using INV.App.Suppliers;
using INV.Domain.Entities.Receptions;
using INVUIs.Suppliers.Models;
using INVUIs.Suppliers;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using INVUIs.Receptions.Models;
using INV.Domain.Shared;

namespace INVUIs.Receptions
{
    public partial class ReceptionList
    {
        [Parameter] public EventCallback<ReceptionModel> OnCommand { get; set; }
        [Parameter] public List<Reception> receptions { get; set; }
        [Parameter] public RenderFragment Pills { get; set; }

        [Inject] public IPurchaseOrderService purchase { get; set; }

        private ReceptionModel commandshow = new ReceptionModel();
        private List<PurchaseOrderInfo> purchases;
        public EditContext editContext { get; set; }
        private bool CommandSelected = false;
        private ReceptionSelector reception = new ReceptionSelector();
        protected override async Task OnInitializedAsync()
        {
          purchases = await purchase.GetPurchaseOrderInfo();
        }

        private async Task CommandSelectednew(Result result)
        {/*
            commandshow = new ReceptionModel
            {
               Date = commandInfo.Date,
               DeliveryNumber = commandInfo.Date.ToString(),
               Status = (ReceptionStatus)commandInfo.Status,

            };
            editContext = new EditContext(commandshow);

           
            StateHasChanged();
            await OnCommand.InvokeAsync(commandshow);*/
        }
    }
}