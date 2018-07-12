using System.Web.Mvc;
using System.Threading.Tasks;
using EmpMVC.Business;


namespace EmpMVCProj.Controllers
{
    public class EmployeeController : Controller
    {
        public IEmployeeBL employeeBL;
        

        public EmployeeController(IEmployeeBL employeeBL)
        {
            this.employeeBL = employeeBL;
        }
        // GET: Employee
        public ActionResult Index()
        {            
            //ViewBag.Employees = employeeBL.GetAllEmployees();
            
            return View();
        }
    }
}