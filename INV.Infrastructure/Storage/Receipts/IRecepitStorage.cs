﻿using INV.Domain.Entities.Purchases;
using INV.Domain.Entities.Receipts;

namespace INV.Infrastructure.Storage.Receipts;

public interface IReceiptStorage
{
    ValueTask<Guid> CreateReceiptFromPurchase(Guid purchaseId);
    ValueTask ValidateReceipt(Guid receiptId);
    ValueTask<List<Receipt>> SelectAllReceipts();
    ValueTask<Receipt?> SelectReceiptById(Guid id);
    ValueTask<List<Receipt>> SelectReceiptsByPurchaseId(Guid purchaseId);
    ValueTask<int> InsertReceipt(Receipt receipt);
    ValueTask<int> UpdateReceipt(Receipt receipt);
    ValueTask<int> DeleteReceipt(Guid id);

    ValueTask<List<ReceiptProduct>> SelectAllReceiptProducts();
    ValueTask<List<ReceiptProduct>> SelectProductsByReceptionId(Guid receptionId);
    ValueTask<int> InsertReceiptProduct(ReceiptProduct receiptProduct);
    ValueTask<int> UpdateReceiptProduct(ReceiptProduct receiptProduct);
    ValueTask<int> DeleteReceiptProduct(Guid receptionId, Guid productId);

    ValueTask<(List<ReceiptProduct> products, Receipt? receipt, PurchaseOrder? purchaseOrder)> GetReceptionDetails(
        Guid receptionId);

}