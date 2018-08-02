using EmpMVC.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EmpMVC.Data.Repositories
{
    
    public class BaseRepository<T> : IBaseRepository<T>
        where T : class, IEntityBase , new()
    {
        protected ApplicationDBContext Context;
        protected DbSet<T> _entities;

        public BaseRepository(ApplicationDBContext context)
        {
            this.Context = context;
            this._entities = Context.Set<T>();
        }
        
        public IEnumerable<T> GetAll()
        {
            return _entities.ToList();
        }        
        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
