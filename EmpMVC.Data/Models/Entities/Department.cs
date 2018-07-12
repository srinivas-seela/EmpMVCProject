using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using EmpMVC.Data.Interfaces;


namespace EmpMVC.Data.Entities
{
    [Table("MST_Department")]
    public class Department : IEntityBase
    {
        [Key]
        public int Department_ID { get; set; }
        public string Department_Name { get; set; }
        public string Descr { get; set; }
        public bool Active_Status { get; set; }
        public string Created_By { get; set; }
        public DateTime Created_Date { get; set; }
        public string Last_Updated_By { get; set; }
        public DateTime Last_Updated_Date { get; set; }
        public ICollection<Employee> Employees { get; set; }
    }
}
