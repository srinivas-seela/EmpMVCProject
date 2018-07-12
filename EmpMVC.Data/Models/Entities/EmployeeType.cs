using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmpMVC.Data.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmpMVC.Data.Entities
{
    [Table("MST_Employee_Type")]
    public class EmployeeType : IEntityBase
    {
        [Key]
        public int Employee_Type_ID { get; set; }
        public string Employee_Type_Code { get; set; }
        public bool Active_Status { get; set; }
        public string Created_By { get; set; }
        public DateTime Created_Date { get; set; }
        public string Last_Updated_By { get; set; }
        public DateTime Last_Updated_Date { get; set; }
    }
}
