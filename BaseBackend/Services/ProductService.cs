using BaseBackend.Interface;
using BaseBackend.Models;
namespace BaseBackend.Services;

public class ProductService : IBaseService<Product>
{ 


    public void Add(Product item)
    {
        
    }

    public void Delete(int id)
    {
        throw new NotImplementedException();
    }

    public List<Product> GetAll()
    {
        throw new NotImplementedException();
    }

    public void Update(Product item)
    {
        throw new NotImplementedException();
    }
}
