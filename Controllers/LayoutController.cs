using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DataAccessLayer.Context;

namespace MyPortfolio.Controllers
{
    public class LayoutController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }
    }
}
