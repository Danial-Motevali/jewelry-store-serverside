
using jewerly.Domain.Contract.Repository;
using jewerly.Domain.Dtos;

namespace jewerly.Infectracture.Repository;

public class GenericRepository<T> : IGenericRepository<T> where T : class
{
    

    public SystemResultDto<T> Delete(T input)
    {
        throw new NotImplementedException();
    }

    public SystemResultDto<T> GetAll()
    {
        throw new NotImplementedException();
    }

    public SystemResultDto<T> GetById(int Id)
    {
        throw new NotImplementedException();
    }

    public SystemResultDto<T> Insert(T input)
    {
        throw new NotImplementedException();
    }

    public SystemResultDto<T> Update(T input)
    {
        throw new NotImplementedException();
    }
}