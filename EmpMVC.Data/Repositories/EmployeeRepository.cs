using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpMVC.Data
{
    public class EmployeeRepository : BaseRepository<Employee>
    {
        public EmployeeRepository(ApplicationDBContext context)
            :base(context)
        { }        
    }
}
