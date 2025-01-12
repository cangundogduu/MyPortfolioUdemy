using Microsoft.AspNetCore.Mvc;
using MyPortfolioUdemy.DAL.Context;
using MyPortfolioUdemy.DAL.Entities;

namespace MyPortfolioUdemy.Controllers
{
	public class ExperienceController : Controller
	{
		MyPortfolioContext context=new MyPortfolioContext();
		public IActionResult ExperienceList()
		{
			var values= context.Experiences.ToList();
			return View(values);
		}

		[HttpGet]
		public IActionResult CreateExperience()
		{
			return View();
		}

		public IActionResult CreateExperience(Experience experience)
		{ 
			context.Experiences.Add(experience);
			context.SaveChanges();
			return RedirectToAction("ExperienceList");
		}
	}
}
