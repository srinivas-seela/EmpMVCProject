
using EmpMVC.Data.Interfaces;
using System.Collections.Generic;
using EmpMVC.Business.Models;
using EmpMVC.Data;
using AutoMapper;

namespace EmpMVC.Business
{
    public class EmployeeBL : IEmployeeBL
    {
        private readonly IEmployeeRepository employeeRepository;
        public EmployeeBL(IEmployeeRepository employeeRepository)
        {
            this.employeeRepository = employeeRepository;
        }
        public IEnumerable<Employee> GetAllEmployees()
        {
            IEnumerable<EmpMVC.Data.Entities.Employee> employeesModel = employeeRepository.GetAll();
            IEnumerable<Employee> employees = Mapper.Map<IEnumerable<EmpMVC.Data.Entities.Employee>, IEnumerable<Employee>>(employeesModel);
            return employees;
        }
    }
}
