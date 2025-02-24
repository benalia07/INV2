using INV.Domain.Entities.Products;

namespace INV.App.Products
{
    public interface IProductService
    {
        Task<int> createProduct(Product product);
        Task<int> SetProducts(Product product);
        Task<int> RemoveProduct(Guid id);
        Task<List<Product>> SelectProducts();
    }
}