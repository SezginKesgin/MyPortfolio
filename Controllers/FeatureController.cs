using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DataAccessLayer.Context;
using MyPortfolio.DataAccessLayer.Entities;

namespace MyPortfolio.Controllers
{
	public class FeatureController : Controller
	{
		MyPortfolioContext context = new MyPortfolioContext();
		public IActionResult FeatureList()
		{
			var values = context.features.ToList();
			return View(values);
		}
		[HttpGet]
		public IActionResult UpdateFeature(int id)
		{
			var value = context.features.Find(id);
			return View(value);
		}
		[HttpPost]
		public IActionResult UpdateFeature(Feature feature)
		{
			context.features.Update(feature);
			context.SaveChanges();
			return RedirectToAction("FeatureList");
		}
	}
}
