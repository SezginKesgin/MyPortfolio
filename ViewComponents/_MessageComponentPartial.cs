using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DataAccessLayer.Context;
using MyPortfolio.DataAccessLayer.Entities;

namespace MyPortfolio.ViewComponents
{
    public class _MessageComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
