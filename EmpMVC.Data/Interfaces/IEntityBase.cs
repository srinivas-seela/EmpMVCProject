using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpMVC.Data
{
    public interface IEntityBase
    {
        int ID { get; set; }
        string Created_By { get; set; }
        DateTime Created_Date { get; set; }
        string Last_Updated_By { get; set; }
        DateTime Last_Updated_Date { get; set; }
    }
}
