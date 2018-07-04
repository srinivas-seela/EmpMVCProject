
using EmpMVC.Data;
using System;
using System.Linq.Expressions;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace EmpMVC.Data
{
    public interface IBaseRepository<T> where T  : class, IEntityBase ,new ()
    {
        void Add(T entity);

        Task AddAsync(T entity);

        void Delete(T entity);

        Task<int> DeleteAsync(T entity);

        void DeleteWhere(Expression<Func<T, bool>> predicate);

        Task<int> DeleteWhereAsync(Expression<Func<T, bool>> predicate);

        void Update(T t, object key);

        Task UpdateAsync(T t, object key);

        int Count();

        Task<int> CountAsync();

        T Find(Expression<Func<T, bool>> match);

        Task<T> FindAsync(Expression<Func<T, bool>> match);

        IEnumerable<T> FindBy(Expression<Func<T, bool>> predicate);

        Task<ICollection<T>> FindByAsync(Expression<Func<T, bool>> predicate);

        ICollection<T> FindAll(Expression<Func<T, bool>> match);

        Task<ICollection<T>> FindAllAsync(Expression<Func<T, bool>> match);

        T GetSingle(int id);

        Task<T> GetSingleAsync(int id);

        T GetSingle(Expression<Func<T, bool>> predicate);

        Task<T> GetSingleAsync(Expression<Func<T, bool>> predicate);

        T GetSingle(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includeProperties);

        Task<T> GetSingleAsync(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includeProperties);

        IEnumerable<T> GetAll();

        Task<ICollection<T>> GetAllAsync();

        IEnumerable<T> GetAllIncluding(params Expression<Func<T, object>>[] includeProperties);

        int ExecuteStoredProcedure(string query, params object[] parameters);

        Task<int> ExecuteStoredProcedureAsync(string query, params object[] parameters);

        void Save();

        Task<int> SaveAsync();

        void Dispose();
    }
}
