using System;

namespace EmpMVC.Business.Models
{
    public class EmployeeType
    {
        public int Employee_Type_ID { get; set; }
        public string Employee_Type_Code { get; set; }
        public bool Active_Status { get; set; }
        public string Created_By { get; set; }
        public DateTime Created_Date { get; set; }
        public string Last_Updated_By { get; set; }
        public DateTime Last_Updated_Date { get; set; }
    }
}
