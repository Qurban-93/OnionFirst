using FirstOnionApplication.Abstracts.Interfaces;
using FirstOnionDomain.Entity;

namespace FirstOnionPersistance.Concretes
{
    public class ProductService : IProductService
    {
        public Task AddAsync(Product item)
        {
            throw new NotImplementedException();
        }

        public void DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Product>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Product> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Product item)
        {
            throw new NotImplementedException();
        }
    }
}
