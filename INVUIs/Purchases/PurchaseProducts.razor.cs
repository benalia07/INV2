﻿using INVUIs.Products.ProductsModel;
using Microsoft.AspNetCore.Components;

namespace INVUIs.Purchases
{
    public partial class PurchaseProducts : ComponentBase
    {
        [Parameter] public EventCallback<List<ProductModel>> OnProductAddProduct { get; set; }

        private List<ProductModel> products = new();
        private bool showPopup = false;
        private ProductModel newProduct = new ProductModel();
        private void OpenPopup()
        {
            showPopup = true;
        }
        private ProductModel? selectedProductModel = null;
        [Parameter] public EventCallback<ProductModel> OnEditProduct { get; set; }


        private void EditProduct(ProductModel product)
        {
            selectedProductModel = new ProductModel
            {
                ID = product.ID,
                IDPurchaseOrder = product.IDPurchaseOrder,
                Designation = product.Designation,
                UnitMeasure = product.UnitMeasure,
                Quantity = product.Quantity,
                UnitPrice = product.UnitPrice,
                TVA = product.TVA,
                DefaultTVARate = product.DefaultTVARate
            };

            OnEditProduct.InvokeAsync(selectedProductModel);
        }
        private void DeleteProduct(ProductModel product)
        {
            products.Remove(product);
            for (int i = 0; i < products.Count; i++)
            {
                products[i].Number = i + 1;
            }
            OnProductAddProduct.InvokeAsync(products);
        }
        public async Task SaveProduct()
        {
            if (newProduct.Quantity > 0)
            {
                int nextNumber = products.Count + 1;
                products.Add(new ProductModel()
                {
                    ID = Guid.NewGuid(),
                    Number = nextNumber,
                    Designation = newProduct.Designation,
                    UnitMeasure = newProduct.UnitMeasure,
                    Quantity = newProduct.Quantity,
                    UnitPrice = newProduct.UnitPrice,
                    TVA = newProduct.TVA,
                    TotalPrice = newProduct.Quantity * newProduct.UnitPrice
                });
                closePopup();
                Clear();
                await OnProductAddProduct.InvokeAsync(products);
            }
        }
        private async Task Clear()
        {
            newProduct = new ProductModel();
        }
        private void closePopup()
        {
            showPopup = false;
            StateHasChanged();
            Clear();
        }
        private bool Display = false;
        public void Show() => Display = !Display;
        public void Close() => Display = false;
        public async Task ProductPass()
        {
            await OnProductAddProduct.InvokeAsync(products);
        }

    }
}