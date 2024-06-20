using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyPortfolio.DataAccessLayer.Context;
using MyPortfolio.DataAccessLayer.Entities;

namespace MyPortfolio.ViewComponents
{
    public class _ContactComponentPartial:ViewComponent
    {
        [HttpPost]
        public IViewComponentResult Invoke()
        {
            MyPortfolioContext context = new MyPortfolioContext();
            var values = context.contacts.Find(1);
            ViewBag.contactTitle = values.Title;
            ViewBag.contactDescription = values.Description;
            ViewBag.contactPhone1 = values.Phone1;
            ViewBag.contactPhone2 = values.Phone2;
            ViewBag.contactEmail1 = values.Email1;
            ViewBag.contactEmail2 = values.Email2;
            ViewBag.contactAdress = values.Address;
            return View();
        }
    }
}
