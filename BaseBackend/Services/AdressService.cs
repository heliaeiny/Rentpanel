using BaseBackend.Interface;
using BaseBackend.Models;

namespace BaseBackend.Services;

public class AdressService : IBaseService<Adress>
{
    List<Adress> adresses = new();
    public void Add(Adress address)
    {
        adresses.Add(address);
    }

    public void Delete(int id)
    {
        throw new NotImplementedException();
    }

    public List<Adress> GetAll()
    {
        return adresses;
    }

    public void Update(Adress item)
    {
        throw new NotImplementedException();
    }
}
