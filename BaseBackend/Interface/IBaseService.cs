

namespace BaseBackend.Interface;

public interface IBaseService<T>
{
    void Update(T item);

    // id ra int mizarim chon adad ast
    void Delete(int id);

    void Add(T item);

    List<T> GetAll();

}
