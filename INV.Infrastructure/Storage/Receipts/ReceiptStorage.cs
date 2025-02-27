using System.Data;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace INV.Infrastructure.Storage.Receipts
{
    public class ReceiptStorage : IReceiptStorage
    {
        private readonly string _connectionString;

        public ReceiptStorage(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("INV");
        }

        private const string CreateReceiptFromPurchaseCommand = "CreateFromPurchase";

        public async ValueTask<Guid> CreateReceiptFromPurchase(Guid purchaseId)
        {
            using var connection = new SqlConnection(_connectionString);
            await connection.OpenAsync();

            using var cmd = new SqlCommand(CreateReceiptFromPurchaseCommand, connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@aPurchaseId", purchaseId);
            var receiptIdParameter = new SqlParameter("@aReceiptId", SqlDbType.UniqueIdentifier)
            {
                Direction = ParameterDirection.Output
            };
            cmd.Parameters.Add(receiptIdParameter);

            await cmd.ExecuteNonQueryAsync();

            return (Guid)receiptIdParameter.Value;
        }


      

        public ValueTask ValidateReceipt(Guid receiptId)
        {
            throw new NotImplementedException();
        }
    }
}