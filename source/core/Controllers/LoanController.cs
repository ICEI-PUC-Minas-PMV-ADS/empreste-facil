using Microsoft.AspNetCore.Mvc;

namespace EmpresteFacil.Controllers
{
    public class LoanController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
