using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DataAccessLayer.Context;

namespace MyPortfolio.ViewComponents
{
    public class _AboutComponentPartial:ViewComponent
    {
        MyPortfolioContext portfolioContext = new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            ViewBag.aboutTitle=portfolioContext.abouts.Select(x=>x.Title).FirstOrDefault();
            ViewBag.aboutSubDescription=portfolioContext.abouts.Select(x=>x.SubDescription).FirstOrDefault();
            ViewBag.aboutDetails=portfolioContext.abouts.Select(x=>x.Details).FirstOrDefault();
            return View();
        }
    }
}
