using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmpMVC.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace EmpMVC.Data
{
    [Table("MST_Employee")]
    public class Employee : IEntityBase
    {
        public int ID { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string First_Name { get; set; }
        public string Middle_Name { get; set; }
        public string Last_Name { get; set; }
        public string Gender { get; set; }
        public Int16 Age { get; set; }
        public Int16 Employee_Type_ID { get; set; }
        public bool Active_Status { get; set; }
        public string Created_By { get; set; }
        public DateTime Created_Date { get; set; }
        public string Last_Updated_By { get; set; }
        public DateTime Last_Updated_Date { get; set; }
    }
}
