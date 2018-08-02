
using EmpMVC.Data.Interfaces;
using System.Collections.Generic;
using EmpMVC.Business.Models;
using EmpMVC.Data;
using AutoMapper;

namespace EmpMVC.Business
{
    public class EmployeeBL : IEmployeeBL
    {
        //private readonly IEmployeeRepository employeeRepository;
        private readonly IUnitOfWork _unitOfWork;

        public EmployeeBL(IUnitOfWork unitOfWork)
        {
            //this.employeeRepository = employeeRepository;
            this._unitOfWork = unitOfWork;
        }
        public IEnumerable<Employee> GetAllEmployees()
        {
            IEnumerable<EmpMVC.Data.Entities.Employee> employeesModel = _unitOfWork.EmployeeRepository.GetAll();
            IEnumerable<Employee> employees = Mapper.Map<IEnumerable<EmpMVC.Data.Entities.Employee>, IEnumerable<Employee>>(employeesModel);
            return employees;
        }
    }
}
