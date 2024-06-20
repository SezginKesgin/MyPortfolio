using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DataAccessLayer.Context;

namespace MyPortfolio.Controllers
{
	public class StatisticController : Controller
	{
		MyPortfolioContext context = new MyPortfolioContext();
		public IActionResult Index()
		{
			ViewBag.yetenekSayisi = context.skills.Count();
			ViewBag.toplamMesaj = context.messages.Count();
			ViewBag.okunmayanMesaj = context.messages.Where(x=>x.IsRead ==false).Count();
			ViewBag.okunanMesaj = context.messages.Where(x=>x.IsRead ==true).Count();
			ViewBag.portfolyoSayisi = context.portfolios.Count();
			ViewBag.sosyalMedyaSayisi = context.socialMedias.Count();
			return View();
		}
	}
}
