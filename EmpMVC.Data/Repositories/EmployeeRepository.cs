using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using EmpMVC.Data.Entities;
using EmpMVC.Data.Interfaces;

namespace EmpMVC.Data.Repositories
{
    public class EmployeeRepository : BaseRepository<Employee> ,IEmployeeRepository
    {
        public EmployeeRepository(ApplicationDBContext context)
            :base(context)
        { }        

        public ApplicationDBContext ApplicationDBContext
        {
            get { return Context as ApplicationDBContext; }
        }
    }
}
