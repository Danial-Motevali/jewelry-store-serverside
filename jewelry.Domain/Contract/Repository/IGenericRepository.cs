using jewerly.Domain.Dtos;

namespace jewelry.Domain.Contract.Repository;

public interface IGenericRepository<T>
{
    T GetById(int Id);
    List<T> GetAll();
    void Insert(T input);
    void Delete(T input);
    void Update(T input);
    int Save();
}