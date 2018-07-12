using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmpMVC.Data;

namespace EmpMVC.Business.Models
{
    public class Employee 
    {
        public int Employee_ID { get; set; }
        public string First_Name { get; set; }
        public string Middle_Name { get; set; }
        public string Last_Name { get; set; }
        public string Gender { get; set; }
        public Int16 Age { get; set; }
        public bool Active_Status { get; set; }
        public string Created_By { get; set; }
        public DateTime Created_Date { get; set; }
        public string Last_Updated_By { get; set; }
        public DateTime Last_Updated_Date { get; set; }
        public int Department_ID { get; set; }
        public int Employee_Type_ID { get; set; }
        public virtual Department Department { get; set; }
        public virtual EmployeeType EmployeeType { get; set; }
        
    }
}
