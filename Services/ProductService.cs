using crudProduct.Models;
using crudProduct.Repositories;

namespace crudProduct.Services
{
    public class ProductService
    {

        private readonly IProductRepository _repository;
        public ProductService(IProductRepository repository)
        {
            _repository = repository;
        }
        public List<Product> GetAll(){
            return _repository.GetAll();
        }

        public Product? GetById(int id)
        {
            return _repository.GetById(id);
        }

        public bool Create(Product product)
        {
            if (string.IsNullOrWhiteSpace(product.Name) || product.Price <= 0 || product.Quantity <= 0)
                return false;

            _repository.Add(product);
            return true;
        }

        public bool Update(int id, Product updated)
        {
            var existing = _repository.GetById(id);
            if (existing == null) return false;

            updated.Id = id;
            _repository.Update(updated);
            return true;
        }

        public bool Delete(int id)
        {
            var product = _repository.GetById(id);
            if (product == null) return false;

            _repository.Delete(id);
            return true;
        }
    }
}
