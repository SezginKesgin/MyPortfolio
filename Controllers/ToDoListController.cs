using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DataAccessLayer.Context;
using MyPortfolio.DataAccessLayer.Entities;

namespace MyPortfolio.Controllers
{
	public class ToDoListController : Controller
	{
		MyPortfolioContext context = new MyPortfolioContext();
		public IActionResult Index()
		{
			var value = context.toDoLists.ToList();
			return View(value);
		}
		[HttpGet]
		public IActionResult CreateToDoList()
		{
			return View();
		}
		[HttpPost]
		public IActionResult CreateToDoList(ToDoList toDoList)
		{
			toDoList.Status = false;
			context.toDoLists.Add(toDoList);
			context.SaveChanges();
			return RedirectToAction("Index");
		}
		public IActionResult DeleteToDoList(int id) 
		{
			var value = context.toDoLists.Find(id);
			context.toDoLists.Remove(value);
			context.SaveChanges();
			return RedirectToAction("Index");
		}
		[HttpGet]
		public IActionResult UpdateToDoList(int id)
		{
			var value =context.toDoLists.Find(id);
			return View(value);
		}
		[HttpPost]
		public IActionResult UpdateToDoList(ToDoList toDoList)
		{
			context.toDoLists.Update(toDoList);
			context.SaveChanges();
			return RedirectToAction("Index");
		}
		public IActionResult ChangeToDoListStatusTrue(int id) 
		{
			var value = context.toDoLists.Find(id);
			value.Status= true;
			context.SaveChanges();
			return RedirectToAction("Index");
		}
		public IActionResult ChangeToDoListStatusFalse(int id)
		{
			var value = context.toDoLists.Find(id);
			value.Status = false;
			context.SaveChanges();
			return RedirectToAction("Index");
		}
	}
}
