

namespace BaseBackend.Interface;

public interface BaseService<T>
{
    void Add(T item);

    List<T> GetAll();

}
