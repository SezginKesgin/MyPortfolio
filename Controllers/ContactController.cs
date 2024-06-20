using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DataAccessLayer.Context;
using MyPortfolio.DataAccessLayer.Entities;

namespace MyPortfolio.Controllers
{
	public class ContactController : Controller
	{
		MyPortfolioContext context = new MyPortfolioContext();
		public IActionResult ContactList()
		{
			var values = context.contacts.ToList();
			return View(values);
		}
		[HttpGet]
		public IActionResult UpdateContact(int id)
		{
			var values = context.contacts.Find(id);
			return View(values);
		}
		[HttpPost]
		public IActionResult UpdateContact(Contact contact)
		{
			context.contacts.Update(contact);
			context.SaveChanges();
			return RedirectToAction("ContactList");
		}
	}
}
