using EmpMVC.Data.Entities;
using System.Data.Entity;
using System.Diagnostics;

namespace EmpMVC.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext()
        {
            Debug.Write(Database.Connection.ConnectionString);
        }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<EmployeeType> EmployeeTypes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            var instance = System.Data.Entity.SqlServer.SqlProviderServices.Instance;

            //modelBuilder.Entity<Employee>()
            //            .HasRequired<Department>(x => x.Department);
                        

            //modelBuilder.Entity<Department>()
            //            .HasOptional(x => x.Employees);
        }

    }
}
