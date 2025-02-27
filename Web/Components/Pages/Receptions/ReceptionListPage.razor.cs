using INV.App.Receipts;
using INV.Domain.Entities.Receptions;
using INV.Shared;
using Microsoft.AspNetCore.Components;

namespace INV.Web.Components.Pages.Receptions
{
    public partial class ReceptionListPage
    {
        [Inject] public IReceiptService ReceptionService { get; set; }
        [Inject] public NavigationManager navigationManager { set; get; }
        private List<Reception> Receptions;
        protected override async Task OnInitializedAsync()
        {
          /*  Receptions = await ReceptionService.g();*/

        }

        private void NavigateToCreateReception() => navigationManager.NavigateTo($"{PageRoutes.CreateReception}");

    }
}