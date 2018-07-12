
using EmpMVC.Data;
using System;
using System.Linq.Expressions;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace EmpMVC.Data.Interfaces
{
    public interface IBaseRepository<T> where T  : class, IEntityBase ,new ()
    {
        
        IEnumerable<T> GetAll();        
        void Dispose();
    }
}
