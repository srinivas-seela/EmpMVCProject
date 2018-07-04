using System.Web.Mvc;
using System.Threading.Tasks;

namespace EmpMVCProj.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public async Task<ActionResult> Index()
        {
            return View();
        }
    }
}