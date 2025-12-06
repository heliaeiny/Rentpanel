using BaseBackend.Interface;
using BaseBackend.Models;

namespace BaseBackend.Services;

public class LessorServices : IBaseService<Lessor>
{
    List<Lessor> lessors = new();

    public void Add(Lessor lessor)
    {
        lessors.Add(lessor);

    }

    public void Delete(int id)
    {
        throw new NotImplementedException();
    }

    public List<Lessor> GetAll()
    {
        return lessors;
    }

    public void Update(Lessor item)
    {
        throw new NotImplementedException();
    }
}
