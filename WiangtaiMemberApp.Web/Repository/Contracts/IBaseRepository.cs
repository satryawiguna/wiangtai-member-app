using System.Linq.Expressions;

namespace WiangtaiMemberApp.Web.Repository.Contracts;

public interface IBaseRepository<T>
{
    IEnumerable<T> GetAll();

    T GetById(int id);

    T GetByFilter(Expression<Func<T, bool>> filter);

    List<T> GetListByFilter(Expression<Func<T, bool>> filter);

    int GetCount(Expression<Func<T, bool>> filter);

    void Insert(T entity);

    void Update(T entity);

    void Remove(T entity);
}
