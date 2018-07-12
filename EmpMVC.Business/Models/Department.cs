using System;
using System.Collections.Generic;

namespace EmpMVC.Business.Models
{
    public class Department 
    {
        public int Department_ID { get; set; }
        public string Department_Name { get; set; }
        public string Descr { get; set; }
        public bool Active_Status { get; set; }
        public string Created_By { get; set; }
        public DateTime Created_Date { get; set; }
        public string Last_Updated_By { get; set; }
        public DateTime Last_Updated_Date { get; set; }
        public IEnumerable<Employee> Employees { get; set; }
    }
}
