using AcmeVendingMachine.Server.Model;
using AcmeVendingMachine.Server.Utility.Data;

namespace AcmeVendingMachine.Server.Services
{

    public class ProductService
    {
        public ProductService()
        {
                
        }
        public virtual List<Product> GetAllProducts()
        {
            return new HardCodedProducts().Products();
        }

        public virtual Product GetProductById(string id)
        {
            var products = this.GetAllProducts();
            return products.FirstOrDefault(x => x.Id == id);
        }

    }
}
