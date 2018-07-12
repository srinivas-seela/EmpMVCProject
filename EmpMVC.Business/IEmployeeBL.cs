using EmpMVC.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EmpMVC.Business
{
    public interface IEmployeeBL
    {
        IEnumerable<Employee> GetAllEmployees();
    }
}
