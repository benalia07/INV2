using INV.App.PurchaseOrders;

using INV.Domain.Entities.Purchases;
using INV.Domain.Entities.SupplierEntity;

namespace INV.Infrastructure.Storage.PurchaseOrders
{
    public interface IPurchaseOrderStorage
    {
        Task<int> InsertPurchaseOrder(PurchaseOrder purchaseOrder);
        Task<List<PurchaseOrder>> SelectPurchaseOrdersByDate(DateOnly dateOnly);
        IAsyncEnumerable<PurchaseOrderInfo> SelectPurchaseOrderInfo();

        Task<int> InsertPurchaseProduct(PurchaseProduct orderDetail);
        Task<List<PurchaseProduct>> SelectAllPurchaseProduct();
        Task<List<PurchaseOrderInfo>> SelectPurchaseOrdersByIdSupplier(Guid IDSupplier);

        Task<PurchaseOrder> SelectPurchaseOrdersByID(Guid id);
        Task<int> ValidatePurchase(PurchaseOrder purchaseOrder);

    }
}