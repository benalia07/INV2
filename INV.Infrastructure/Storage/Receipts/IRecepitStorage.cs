namespace INV.Infrastructure.Storage.Receipts;

public interface IReceiptStorage
{
    ValueTask<Guid> CreateReceiptFromPurchase(Guid purchaseId);
    ValueTask ValidateReceipt(Guid receiptId);
    
}