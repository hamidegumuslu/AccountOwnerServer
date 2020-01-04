using Entities.Models;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace Contracts

{
    public interface IRepositoryWrapper
    {
        IOwnerRepository Owner { get; }
        IAccountRepository Account { get; }
        void Save();
    }
    public interface IAccountRepository : IRepositoryBase<Account>
    {
    }
    public interface IOwnerRepository : IRepositoryBase<Owner>
    {
    }

    public interface IRepositoryBase<T>
    {
        IQueryable<T> FindAll();
        IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression);
        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
    public interface ILoggerManager
    {
        void LogInfo(string message);
        void LogWarn(string message);
        void LogDebug(string message);
        void LogError(string message);
    }

}
