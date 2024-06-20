using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DataAccessLayer.Context;
using MyPortfolio.DataAccessLayer.Entities;

namespace MyPortfolio.Controllers
{
	public class AboutController : Controller
	{
		MyPortfolioContext context = new MyPortfolioContext();
		public IActionResult AboutList()
		{
			var values = context.abouts.ToList();
			return View(values);
		}
		[HttpGet]
		public IActionResult UpdateAbout(int id) 
		{
			var values = context.abouts.Find(id);
			return View(values);
		}
		[HttpPost]
		public IActionResult UpdateAbout(About about)
		{
			context.abouts.Update(about);
			context.SaveChanges();
			return RedirectToAction("AboutList");
		}


	}
}
