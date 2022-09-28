using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using WiangtaiMemberApp.Data;
using WiangtaiMemberApp.Web.Repository.Contracts;

namespace WiangtaiMemberApp.Web.Repository;

public class BaseRepository<T> : IBaseRepository<T> where T : class, new()
{
    protected readonly WiangtaiMemberAppDbContext _context;
    protected readonly DbSet<T> _entities;

    public BaseRepository(WiangtaiMemberAppDbContext context)
    {
        _context = context;
        _entities = context.Set<T>();
    }

    public IEnumerable<T> GetAll()
    {
        return _entities.AsEnumerable();
    }

    public T GetById(int id)
    {
        return _entities.Find(id);
    }

    public T GetByFilter(Expression<Func<T, bool>> filter)
    {
        return _entities.SingleOrDefault(filter);
    }

    public List<T> GetListByFilter(Expression<Func<T, bool>> filter)
    {
        return _entities.Where(filter).ToList();
    }

    public int GetCount(Expression<Func<T, bool>> filter)
    {
        return _entities.Count(filter);
    }

    public void Insert(T entity)
    {
        if (entity == null)
        {
            throw new ArgumentNullException("entity");
        }

        _entities.Add(entity);

        SaveChanges();
    }

    public void Update(T entity)
    {
        if (entity == null)
        {
            throw new ArgumentNullException("entity");
        }

        _entities.Update(entity);

        SaveChanges();
    }

    public void Remove(T entity)
    {
        if (entity == null)
        {
            throw new ArgumentNullException("entity");
        }

        _entities.Remove(entity);

        SaveChanges();
    }

    private void SaveChanges()
    {
        _context.SaveChanges();
    }
}