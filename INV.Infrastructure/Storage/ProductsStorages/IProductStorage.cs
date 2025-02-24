using INV.Domain.Entities.Products;

namespace INV.Infrastructure.Storage.ProductsStorages
{
    public interface IProductStorage
    {

        Task<int> InsertProduct(Product product);
        Task<int> UpdateProduct(Product product);
        Task<int> DeleteProduct(Guid id);
        Task<List<Product>> SelectProducts();
    }
}

