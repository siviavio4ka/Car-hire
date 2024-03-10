using System.Linq.Expressions;
using Car_hire.DAL.Contracts;
using Microsoft.EntityFrameworkCore;

namespace Car_hire.DAL.Repository;

public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
{
    protected ApplicationContext ApplicationContext;

    public RepositoryBase(ApplicationContext applicationContext)
    {
        ApplicationContext = applicationContext;
    }

    public IQueryable<T> FindAll(bool trackChanges) =>
        !trackChanges
            ? ApplicationContext.Set<T>()
                .AsNoTracking()
            : ApplicationContext.Set<T>();

    public IQueryable<T> FindByCondition(Expression<Func<T, bool>> exception, bool trackChanges) =>
        !trackChanges
            ? ApplicationContext.Set<T>()
                .Where(exception)
                .AsNoTracking()
            : ApplicationContext.Set<T>()
                .Where(exception);

    public void Create(T entity) => ApplicationContext.Set<T>().Add(entity);

    public void Update(T entity) => ApplicationContext.Set<T>().Update(entity);

    public void Delete(T entity) => ApplicationContext.Set<T>().Remove(entity);
}