using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DataAccessLayer.Context;
using MyPortfolio.DataAccessLayer.Entities;

namespace MyPortfolio.Controllers
{
	public class ExperienceController : Controller
	{
		MyPortfolioContext context = new MyPortfolioContext();
		public IActionResult ExperienceList()
		{
			var values = context.experiences.ToList();
			return View(values);
		}

		[HttpGet]
		public IActionResult AddExperience()
		{
			return View();
		}
		[HttpPost]
		public IActionResult AddExperience(Experience experience)
		{
			context.experiences.Add(experience);
			context.SaveChanges();
			return RedirectToAction("ExperienceList");
		}
		[HttpGet]
		public IActionResult UpdateExperience(int id)
		{
			var value = context.experiences.Find(id);
			return View(value);
		}
		[HttpPost]
		public IActionResult UpdateExperience(Experience experience )
		{
			context.experiences.Update(experience);
			context.SaveChanges();
			return RedirectToAction("ExperienceList");
		}
		public IActionResult DeleteExperience(int id)
		{
			var value = context.experiences.Find(id);
			context.experiences.Remove(value);
			context.SaveChanges();
			return RedirectToAction("ExperienceList");
		}
	}
}
