﻿using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DataAccessLayer.Context;

namespace MyPortfolio.ViewComponents.LayoutViewComponents
{
	public class _LayoutSidebarComponentPartial: ViewComponent
	{
		MyPortfolioContext context = new MyPortfolioContext();
		public IViewComponentResult Invoke()
		{
			ViewBag.mesajsayi = context.messages.Where(x => x.IsRead == false).Count();
			ViewBag.yapilacaksayi = context.toDoLists.Where(x => x.Status == false).Count();
			return View();
		}
	}
}
