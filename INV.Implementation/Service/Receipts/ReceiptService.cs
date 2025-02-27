using System.Runtime.InteropServices.JavaScript;
using INV.App.Receipts;
using INV.Domain.Shared;
using INV.Infrastructure.Storage.Receipts;

namespace INV.Implementation.Service.Receipts
{
    public class ReceiptService : IReceiptService
    {
        private readonly IReceiptStorage receiptStorage;

        public ReceiptService(IReceiptStorage receiptStorage)
        {
            this.receiptStorage = receiptStorage;
        }

        public ValueTask<Result<Guid>> CreateReceiptFromPurchase(Guid purchaseId)
        {
            try
            {
                Guid receiptId = receiptStorage.CreateReceiptFromPurchase(purchaseId).Result;
                return new ValueTask<Result<Guid>>(Result.Success(receiptId));
            }
            catch (Exception e)
            {
                return new ValueTask<Result<Guid>>
                (Result.Failure<Guid>(Error.Problem("Erorr return receiptId",
                    $"Error message: {e.Message}")));
            }
        }
        public ValueTask ValidateReceipt(Guid receiptId)
        {
            try
            {

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            throw new NotImplementedException();
        }
    }
}