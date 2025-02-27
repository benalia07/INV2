using INV.Domain.Shared;

namespace INV.App.Receipts;

public interface IReceiptService
{
    ValueTask<Result<Guid>> CreateReceiptFromPurchase(Guid purchaseId);
    ValueTask ValidateReceipt(Guid receiptId);
}

