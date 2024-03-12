using BusinessObject;

namespace DataAccess.Repository
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAll();
        Product? GetById(int id);
        void Insert(Product member);
        void Update(Product member);
        void Remove(int id);
    }
}
