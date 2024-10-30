using jewerly.Domain.Dtos;

namespace jewerly.Domain.Contract.Repository;

public interface IGenericRepository<T>
{
    SystemResultDto<T> GetById(int Id);
    SystemResultDto<T> GetAll();
    SystemResultDto<T> Insert(T input);
    SystemResultDto<T> Delete(T input);
    SystemResultDto<T> Update(T input);
}