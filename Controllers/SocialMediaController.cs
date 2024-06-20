using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis;
using MyPortfolio.DataAccessLayer.Context;
using MyPortfolio.DataAccessLayer.Entities;

namespace MyPortfolio.Controllers
{
	public class SocialMediaController : Controller
	{
		MyPortfolioContext context = new MyPortfolioContext();
		public IActionResult SocialMediaList()
		{
			var values = context.socialMedias.ToList();
			return View(values);
		}
		[HttpGet]
		public IActionResult AddSocialMedia()
		{
			return View();
		}
		[HttpPost]
		public IActionResult AddSocialMedia(SocialMedia socialMedia)
		{
			context.socialMedias.Add(socialMedia);
			context.SaveChanges();
			return RedirectToAction("SocialMediaList");
		}
		[HttpGet]
		public IActionResult UpdateSocialMedia(int id)
		{
			var values = context.socialMedias.Find(id);
			return View(values);
		}
		[HttpPost]
		public IActionResult UpdateSocialMedia(SocialMedia socialMedia)
		{
			context.socialMedias.Update(socialMedia);
			context.SaveChanges();
			return RedirectToAction("SocialMediaList");
		}
		public IActionResult DeleteSocialMedia(int id)
		{
			var values = context.socialMedias.Find(id);
			context.socialMedias.Remove(values);
			context.SaveChanges();
			return RedirectToAction("SocialMediaList");

		}

	}
}
