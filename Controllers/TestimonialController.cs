using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DataAccessLayer.Context;
using MyPortfolio.DataAccessLayer.Entities;

namespace MyPortfolio.Controllers
{
	public class TestimonialController : Controller
	{
		MyPortfolioContext context = new MyPortfolioContext();
		public IActionResult TestimonialList()
		{
			var values = context.testimonials.ToList();
			return View(values);
		}
		[HttpGet]
		public IActionResult AddTestimonial()
		{
			return View();
		}
		[HttpPost]
		public IActionResult AddTestimonial(Testimonial testimonial)
		{
			context.testimonials.Add(testimonial);
			context.SaveChanges();
			return RedirectToAction("TestimonialList");
		}
		public IActionResult DeleteTestimonial(int id)
		{
			var values = context.testimonials.Find(id);
			context.testimonials.Remove(values);
			context.SaveChanges();
			return RedirectToAction("TestimonialList");
		}
		[HttpGet]
		public IActionResult UpdateTestimonial(int id)
		{
			var value = context.testimonials.Find(id);
			return View(value);
		}
		[HttpPost]
		public IActionResult UpdateTestimonial(Testimonial testimonial)
		{
			context.testimonials.Update(testimonial);
			context.SaveChanges();
			return RedirectToAction("TestimonialList");
		}
	}
}
