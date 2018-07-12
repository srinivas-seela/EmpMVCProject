using EmpMVC.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpMVC.Data.Interfaces
{
    public interface IEmployeeRepository : IBaseRepository<Employee>
    {
        
    }
}
