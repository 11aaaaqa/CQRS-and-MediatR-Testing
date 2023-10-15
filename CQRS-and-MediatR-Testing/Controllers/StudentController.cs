using Microsoft.AspNetCore.Mvc;

namespace CQRS_and_MediatR_Testing.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
