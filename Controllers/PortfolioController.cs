using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DataAccessLayer.Context;
using MyPortfolio.DataAccessLayer.Entities;

namespace MyPortfolio.Controllers
{
	public class PortfolioController : Controller
	{
		MyPortfolioContext context = new MyPortfolioContext();
		public IActionResult PortfolioList()
		{
			var values = context.portfolios.ToList();
			return View(values);
		}
		[HttpGet]
		public IActionResult AddPortfolio()
		{
			return View();
		}
		[HttpPost]
		public IActionResult AddPortfolio(Portfolio portfolio)
		{
			context.portfolios.Add(portfolio);
			context.SaveChanges();
			return RedirectToAction("PortfolioList");
		}
		public IActionResult DeletePortfolio(int id)
		{
			var values = context.portfolios.Find(id);
			context.portfolios.Remove(values);
			context.SaveChanges();
			return RedirectToAction("PortfolioList");
		}
		[HttpGet]
		public IActionResult UpdatePortfolio(int id)
		{
			var values = context.portfolios.Find(id);
			return View(values);
		}
		[HttpPost]
		public IActionResult UpdatePortfolio(Portfolio portfolio)
		{
			context.portfolios.Update(portfolio);
			context.SaveChanges();
			return RedirectToAction("PortfolioList");
		}
	}
}
