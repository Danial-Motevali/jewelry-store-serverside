
using jewelry.Domain.Contract.Repository;
using jewerly.Domain.Dtos;
using jewerly.Infectracture.Data;
using Microsoft.EntityFrameworkCore;

namespace jewerly.Infectracture.Repository;

public class GenericRepository<T> : IGenericRepository<T> where T : class
{
    private ApplicationDbContext _context;
    private DbSet<T> _dbSet;

    public GenericRepository(ApplicationDbContext context)
    {
        _context = context;
        _dbSet = context.Set<T>();
    }

    public void Delete(T input)
    {
        if(_context.Entry(input).State == EntityState.Detached){
            _dbSet.Attach(input);
        }

        _dbSet.Remove(input);
    }

    public List<T> GetAll()
    {
        return _dbSet.ToList();
    }

    public T GetById(int Id)
    {
        return _dbSet.Find(Id);
    }

    public void Insert(T input)
    {
        _dbSet.Add(input);
    }

    public int Save()
    {
        return _context.SaveChanges();
    }

    public void Update(T input)
    {
        _dbSet.Attach(input);
        _context.Entry(input).State = EntityState.Modified;
    }
}