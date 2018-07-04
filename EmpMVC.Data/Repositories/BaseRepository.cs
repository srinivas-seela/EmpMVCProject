using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EmpMVC.Data
{
    
    public class BaseRepository<T> : IBaseRepository<T>
        where T : class, IEntityBase , new()
    {
        private readonly ApplicationDBContext _context;
        private DbSet<T> _entities;

        public BaseRepository(ApplicationDBContext context)
        {
            this._context = context;
            this._entities = _context.Set<T>();
        }

        public void Add(T entity)
        {
            _entities.Add(entity);
        }

        public Task AddAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public int Count()
        {
            throw new NotImplementedException();
        }

        public Task<int> CountAsync()
        {
            throw new NotImplementedException();
        }

        public void Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public void DeleteWhere(Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteWhereAsync(Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }       

        public int ExecuteStoredProcedure(string query, params object[] parameters)
        {
            throw new NotImplementedException();
        }

        public Task<int> ExecuteStoredProcedureAsync(string query, params object[] parameters)
        {
            throw new NotImplementedException();
        }

        public T Find(Expression<Func<T, bool>> match)
        {
            throw new NotImplementedException();
        }

        public ICollection<T> FindAll(Expression<Func<T, bool>> match)
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<T>> FindAllAsync(Expression<Func<T, bool>> match)
        {
            throw new NotImplementedException();
        }

        public Task<T> FindAsync(Expression<Func<T, bool>> match)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> FindBy(Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<T>> FindByAsync(Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetAll()
        {
            return _entities;
        }

        public Task<ICollection<T>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetAllIncluding(params Expression<Func<T, object>>[] includeProperties)
        {
            throw new NotImplementedException();
        }

        public T GetSingle(int id)
        {
            throw new NotImplementedException();
        }

        public T GetSingle(Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public T GetSingle(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includeProperties)
        {
            throw new NotImplementedException();
        }

        public Task<T> GetSingleAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<T> GetSingleAsync(Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<T> GetSingleAsync(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includeProperties)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public Task<int> SaveAsync()
        {
            throw new NotImplementedException();
        }

        public void Update(T t, object key)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(T t, object key)
        {
            throw new NotImplementedException();
        }
        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
