using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmpMVC.Data;


namespace EmpMVC.Data
{
    public class ApplicationDBContext : DbContext
    {
        DbSet<Employee> Employees { get; set; }
    }
}
