namespace CQRSMediatr.Models
{
    public class FakeDataStore
    {
        private static List<Product> _products;
        public FakeDataStore()
        {
            _products = new List<Product>()
            {
                new Product { Id = 1,Name="Product 1"},
                new Product { Id = 2,Name="Product 2"},
                new Product { Id = 3,Name="Product 3"},
            };
        }
        public async Task AddProduct(Product product)
        {
            _products.Add(product);
            await Task.CompletedTask;
        }
        public async Task<IEnumerable<Product>> GetProducts()
        {
            return await Task.FromResult(_products);
        }
        public async Task<Product> GetProductById(int Id)
        {
            var product = _products.First(c => c.Id == Id);
            return await Task.FromResult(product);
        }
    }
}
