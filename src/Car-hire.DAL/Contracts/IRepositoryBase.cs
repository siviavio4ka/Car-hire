using System.Linq.Expressions;

namespace Car_hire.DAL.Contracts;

public interface IRepositoryBase<T>
{
    IQueryable<T> FindAll(bool trackChanges);
    IQueryable<T> FindByCondition(Expression<Func<T, bool>> exception, bool trackChanges);
    void Create(T entity);
    void Update(T entity);
    void Delete(T entity);
}